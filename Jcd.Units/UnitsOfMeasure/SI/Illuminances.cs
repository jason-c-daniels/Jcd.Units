using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Illuminance.
/// </summary>
public class Illuminances : Enumeration<Illuminances,Illuminance>
{
    public static readonly Illuminance Lux = new ("lux", "lx");
    public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0/10.0,0);
    public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0/10.0,0);
    public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0/10.0,0);
    public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0/1000.0,0);
    public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0/1000.0,0);
    public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0/1000.0,0);
    public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0/1000.0,0);
    public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0/1000.0,0);
    public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0/1000.0,0);
    public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0/1000.0,0);
    public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0/1000.0,0);
    public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0/1000.0,0);
    public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10,0);
    public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10,0);
    public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10,0);
    public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000,0);
    public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000,0);
    public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000,0);
    public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000,0);
    public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000,0);
    public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000,0);
    public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000,0);
    public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000,0);
    public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000,0);
}