using Jcd.Units.UnitTypes;

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
    /// A(n) decilux. Defined in terms of a(n) lux.
    /// </summary>
    public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0/10.0,0);

    /// <summary>
    /// A(n) centilux. Defined in terms of a(n) decilux.
    /// </summary>
    public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0/10.0,0);

    /// <summary>
    /// A(n) millilux. Defined in terms of a(n) centilux.
    /// </summary>
    public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0/10.0,0);

    /// <summary>
    /// A(n) microlux. Defined in terms of a(n) millilux.
    /// </summary>
    public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanolux. Defined in terms of a(n) microlux.
    /// </summary>
    public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picolux. Defined in terms of a(n) nanolux.
    /// </summary>
    public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtolux. Defined in terms of a(n) picolux.
    /// </summary>
    public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attolux. Defined in terms of a(n) femtolux.
    /// </summary>
    public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptolux. Defined in terms of a(n) attolux.
    /// </summary>
    public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctolux. Defined in terms of a(n) zeptolux.
    /// </summary>
    public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontolux. Defined in terms of a(n) yoctolux.
    /// </summary>
    public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectolux. Defined in terms of a(n) rontolux.
    /// </summary>
    public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekalux. Defined in terms of a(n) lux.
    /// </summary>
    public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10,0);

    /// <summary>
    /// A(n) hectolux. Defined in terms of a(n) dekalux.
    /// </summary>
    public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10,0);

    /// <summary>
    /// A(n) kilolux. Defined in terms of a(n) hectolux.
    /// </summary>
    public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10,0);

    /// <summary>
    /// A(n) megalux. Defined in terms of a(n) kilolux.
    /// </summary>
    public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000,0);

    /// <summary>
    /// A(n) gigalux. Defined in terms of a(n) megalux.
    /// </summary>
    public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000,0);

    /// <summary>
    /// A(n) teralux. Defined in terms of a(n) gigalux.
    /// </summary>
    public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000,0);

    /// <summary>
    /// A(n) petalux. Defined in terms of a(n) teralux.
    /// </summary>
    public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000,0);

    /// <summary>
    /// A(n) exalux. Defined in terms of a(n) petalux.
    /// </summary>
    public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000,0);

    /// <summary>
    /// A(n) zettalux. Defined in terms of a(n) exalux.
    /// </summary>
    public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000,0);

    /// <summary>
    /// A(n) yottalux. Defined in terms of a(n) zettalux.
    /// </summary>
    public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000,0);

    /// <summary>
    /// A(n) ronnalux. Defined in terms of a(n) yottalux.
    /// </summary>
    public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000,0);

    /// <summary>
    /// A(n) quettalux. Defined in terms of a(n) ronnalux.
    /// </summary>
    public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000,0);

}