using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Illuminance.
/// </summary>
public class Illuminances : Enumeration<Illuminances,Illuminance>
{

    /// <summary>
    /// Units of a lux.
    /// </summary>
    public static readonly Illuminance Lux = new ("lux", "lx");
    /// <summary>
    /// Units of a decilux. It's defined in terms of a(n) SI lux.
    /// </summary>
    public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0/10.0,0);
    /// <summary>
    /// Units of a centilux. It's defined in terms of a(n) SI decilux.
    /// </summary>
    public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0/10.0,0);
    /// <summary>
    /// Units of a millilux. It's defined in terms of a(n) SI centilux.
    /// </summary>
    public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0/10.0,0);
    /// <summary>
    /// Units of a microlux. It's defined in terms of a(n) SI millilux.
    /// </summary>
    public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanolux. It's defined in terms of a(n) SI microlux.
    /// </summary>
    public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picolux. It's defined in terms of a(n) SI nanolux.
    /// </summary>
    public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtolux. It's defined in terms of a(n) SI picolux.
    /// </summary>
    public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attolux. It's defined in terms of a(n) SI femtolux.
    /// </summary>
    public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptolux. It's defined in terms of a(n) SI attolux.
    /// </summary>
    public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctolux. It's defined in terms of a(n) SI zeptolux.
    /// </summary>
    public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontolux. It's defined in terms of a(n) SI yoctolux.
    /// </summary>
    public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectolux. It's defined in terms of a(n) SI rontolux.
    /// </summary>
    public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekalux. It's defined in terms of a(n) SI lux.
    /// </summary>
    public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10,0);
    /// <summary>
    /// Units of a hectolux. It's defined in terms of a(n) SI dekalux.
    /// </summary>
    public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10,0);
    /// <summary>
    /// Units of a kilolux. It's defined in terms of a(n) SI hectolux.
    /// </summary>
    public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10,0);
    /// <summary>
    /// Units of a megalux. It's defined in terms of a(n) SI kilolux.
    /// </summary>
    public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000,0);
    /// <summary>
    /// Units of a gigalux. It's defined in terms of a(n) SI megalux.
    /// </summary>
    public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000,0);
    /// <summary>
    /// Units of a teralux. It's defined in terms of a(n) SI gigalux.
    /// </summary>
    public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000,0);
    /// <summary>
    /// Units of a petalux. It's defined in terms of a(n) SI teralux.
    /// </summary>
    public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000,0);
    /// <summary>
    /// Units of a exalux. It's defined in terms of a(n) SI petalux.
    /// </summary>
    public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000,0);
    /// <summary>
    /// Units of a zettalux. It's defined in terms of a(n) SI exalux.
    /// </summary>
    public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000,0);
    /// <summary>
    /// Units of a yottalux. It's defined in terms of a(n) SI zettalux.
    /// </summary>
    public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000,0);
    /// <summary>
    /// Units of a ronnalux. It's defined in terms of a(n) SI yottalux.
    /// </summary>
    public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000,0);
    /// <summary>
    /// Units of a quettalux. It's defined in terms of a(n) SI ronnalux.
    /// </summary>
    public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000,0);

}