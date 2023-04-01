#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Illuminance.
/// </summary>
public class Illuminances : UnitOfMeasureEnumeration<Illuminances, Illuminance>
{
   /// <summary>
   /// lux, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Illuminance Lux = new ("lux", "lx", system: "SI");

   /// <summary>
   /// decilux defined such that: lux = dlx × 1.0/10.0.
   /// </summary>
   public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centilux defined such that: decilux = clx × 1.0/10.0.
   /// </summary>
   public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millilux defined such that: centilux = mlx × 1.0/10.0.
   /// </summary>
   public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microlux defined such that: millilux = μlx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanolux defined such that: microlux = nlx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picolux defined such that: nanolux = plx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtolux defined such that: picolux = flx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attolux defined such that: femtolux = alx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptolux defined such that: attolux = zlx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctolux defined such that: zeptolux = ylx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontolux defined such that: yoctolux = rlx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectolux defined such that: rontolux = qlx × 1.0/1000.0.
   /// </summary>
   public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekalux defined such that: lux = dalx × 10.0.
   /// </summary>
   public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10.0, system: "SI");

   /// <summary>
   /// hectolux defined such that: dekalux = hlx × 10.0.
   /// </summary>
   public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10.0, system: "SI");

   /// <summary>
   /// kilolux defined such that: hectolux = klx × 10.0.
   /// </summary>
   public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10.0, system: "SI");

   /// <summary>
   /// megalux defined such that: kilolux = Mlx × 1000.0.
   /// </summary>
   public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000.0, system: "SI");

   /// <summary>
   /// gigalux defined such that: megalux = Glx × 1000.0.
   /// </summary>
   public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000.0, system: "SI");

   /// <summary>
   /// teralux defined such that: gigalux = Tlx × 1000.0.
   /// </summary>
   public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000.0, system: "SI");

   /// <summary>
   /// petalux defined such that: teralux = Plx × 1000.0.
   /// </summary>
   public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000.0, system: "SI");

   /// <summary>
   /// exalux defined such that: petalux = Elx × 1000.0.
   /// </summary>
   public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000.0, system: "SI");

   /// <summary>
   /// zettalux defined such that: exalux = Zlx × 1000.0.
   /// </summary>
   public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000.0, system: "SI");

   /// <summary>
   /// yottalux defined such that: zettalux = Ylx × 1000.0.
   /// </summary>
   public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000.0, system: "SI");

   /// <summary>
   /// ronnalux defined such that: yottalux = Rlx × 1000.0.
   /// </summary>
   public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000.0, system: "SI");

   /// <summary>
   /// quettalux defined such that: ronnalux = Qlx × 1000.0.
   /// </summary>
   public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000.0, system: "SI");
}
