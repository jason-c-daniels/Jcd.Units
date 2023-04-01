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
   /// decilux, defined as: lux × 1.0/10.0
   /// </summary>
   public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centilux, defined as: decilux × 1.0/10.0
   /// </summary>
   public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millilux, defined as: centilux × 1.0/10.0
   /// </summary>
   public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microlux, defined as: millilux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanolux, defined as: microlux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picolux, defined as: nanolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtolux, defined as: picolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attolux, defined as: femtolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptolux, defined as: attolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctolux, defined as: zeptolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontolux, defined as: yoctolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectolux, defined as: rontolux × 1.0/1000.0
   /// </summary>
   public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekalux, defined as: lux × 10.0
   /// </summary>
   public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10.0, system: "SI");

   /// <summary>
   /// hectolux, defined as: dekalux × 10.0
   /// </summary>
   public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10.0, system: "SI");

   /// <summary>
   /// kilolux, defined as: hectolux × 10.0
   /// </summary>
   public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10.0, system: "SI");

   /// <summary>
   /// megalux, defined as: kilolux × 1000.0
   /// </summary>
   public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000.0, system: "SI");

   /// <summary>
   /// gigalux, defined as: megalux × 1000.0
   /// </summary>
   public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000.0, system: "SI");

   /// <summary>
   /// teralux, defined as: gigalux × 1000.0
   /// </summary>
   public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000.0, system: "SI");

   /// <summary>
   /// petalux, defined as: teralux × 1000.0
   /// </summary>
   public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000.0, system: "SI");

   /// <summary>
   /// exalux, defined as: petalux × 1000.0
   /// </summary>
   public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000.0, system: "SI");

   /// <summary>
   /// zettalux, defined as: exalux × 1000.0
   /// </summary>
   public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000.0, system: "SI");

   /// <summary>
   /// yottalux, defined as: zettalux × 1000.0
   /// </summary>
   public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000.0, system: "SI");

   /// <summary>
   /// ronnalux, defined as: yottalux × 1000.0
   /// </summary>
   public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000.0, system: "SI");

   /// <summary>
   /// quettalux, defined as: ronnalux × 1000.0
   /// </summary>
   public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000.0, system: "SI");
}
