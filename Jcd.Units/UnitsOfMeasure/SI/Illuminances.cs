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
   /// A(n) lux.
   /// </summary>
   public static readonly Illuminance Lux = new ("lux", "lx");

   /// <summary>
   /// A(n) decilux. Defined as: (1.0/10.0) × lux + (0).
   /// </summary>
   public static readonly Illuminance Decilux = new ("decilux", "dlx", Lux, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centilux. Defined as: (1.0/10.0) × decilux + (0).
   /// </summary>
   public static readonly Illuminance Centilux = new ("centilux", "clx", Decilux, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millilux. Defined as: (1.0/10.0) × centilux + (0).
   /// </summary>
   public static readonly Illuminance Millilux = new ("millilux", "mlx", Centilux, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microlux. Defined as: (1.0/1000.0) × millilux + (0).
   /// </summary>
   public static readonly Illuminance Microlux = new ("microlux", "μlx", Millilux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanolux. Defined as: (1.0/1000.0) × microlux + (0).
   /// </summary>
   public static readonly Illuminance Nanolux = new ("nanolux", "nlx", Microlux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picolux. Defined as: (1.0/1000.0) × nanolux + (0).
   /// </summary>
   public static readonly Illuminance Picolux = new ("picolux", "plx", Nanolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtolux. Defined as: (1.0/1000.0) × picolux + (0).
   /// </summary>
   public static readonly Illuminance Femtolux = new ("femtolux", "flx", Picolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attolux. Defined as: (1.0/1000.0) × femtolux + (0).
   /// </summary>
   public static readonly Illuminance Attolux = new ("attolux", "alx", Femtolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptolux. Defined as: (1.0/1000.0) × attolux + (0).
   /// </summary>
   public static readonly Illuminance Zeptolux = new ("zeptolux", "zlx", Attolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctolux. Defined as: (1.0/1000.0) × zeptolux + (0).
   /// </summary>
   public static readonly Illuminance Yoctolux = new ("yoctolux", "ylx", Zeptolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontolux. Defined as: (1.0/1000.0) × yoctolux + (0).
   /// </summary>
   public static readonly Illuminance Rontolux = new ("rontolux", "rlx", Yoctolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectolux. Defined as: (1.0/1000.0) × rontolux + (0).
   /// </summary>
   public static readonly Illuminance Quectolux = new ("quectolux", "qlx", Rontolux, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekalux. Defined as: (10.0) × lux + (0).
   /// </summary>
   public static readonly Illuminance Dekalux = new ("dekalux", "dalx", Lux, 10.0, 0);

   /// <summary>
   /// A(n) hectolux. Defined as: (10.0) × dekalux + (0).
   /// </summary>
   public static readonly Illuminance Hectolux = new ("hectolux", "hlx", Dekalux, 10.0, 0);

   /// <summary>
   /// A(n) kilolux. Defined as: (10.0) × hectolux + (0).
   /// </summary>
   public static readonly Illuminance Kilolux = new ("kilolux", "klx", Hectolux, 10.0, 0);

   /// <summary>
   /// A(n) megalux. Defined as: (1000.0) × kilolux + (0).
   /// </summary>
   public static readonly Illuminance Megalux = new ("megalux", "Mlx", Kilolux, 1000.0, 0);

   /// <summary>
   /// A(n) gigalux. Defined as: (1000.0) × megalux + (0).
   /// </summary>
   public static readonly Illuminance Gigalux = new ("gigalux", "Glx", Megalux, 1000.0, 0);

   /// <summary>
   /// A(n) teralux. Defined as: (1000.0) × gigalux + (0).
   /// </summary>
   public static readonly Illuminance Teralux = new ("teralux", "Tlx", Gigalux, 1000.0, 0);

   /// <summary>
   /// A(n) petalux. Defined as: (1000.0) × teralux + (0).
   /// </summary>
   public static readonly Illuminance Petalux = new ("petalux", "Plx", Teralux, 1000.0, 0);

   /// <summary>
   /// A(n) exalux. Defined as: (1000.0) × petalux + (0).
   /// </summary>
   public static readonly Illuminance Exalux = new ("exalux", "Elx", Petalux, 1000.0, 0);

   /// <summary>
   /// A(n) zettalux. Defined as: (1000.0) × exalux + (0).
   /// </summary>
   public static readonly Illuminance Zettalux = new ("zettalux", "Zlx", Exalux, 1000.0, 0);

   /// <summary>
   /// A(n) yottalux. Defined as: (1000.0) × zettalux + (0).
   /// </summary>
   public static readonly Illuminance Yottalux = new ("yottalux", "Ylx", Zettalux, 1000.0, 0);

   /// <summary>
   /// A(n) ronnalux. Defined as: (1000.0) × yottalux + (0).
   /// </summary>
   public static readonly Illuminance Ronnalux = new ("ronnalux", "Rlx", Yottalux, 1000.0, 0);

   /// <summary>
   /// A(n) quettalux. Defined as: (1000.0) × ronnalux + (0).
   /// </summary>
   public static readonly Illuminance Quettalux = new ("quettalux", "Qlx", Ronnalux, 1000.0, 0);
}
