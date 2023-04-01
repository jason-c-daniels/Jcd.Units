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
/// International System of Units for measuring Luminous Flux.
/// </summary>
public class LuminousFluxes : UnitOfMeasureEnumeration<LuminousFluxes, LuminousFlux>
{
   /// <summary>
   /// lumen, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly LuminousFlux Lumen = new ("lumen", "lm", system: "SI");

   /// <summary>
   /// decilumen, defined as: lumen × 1.0/10.0
   /// </summary>
   public static readonly LuminousFlux Decilumen = new ("decilumen", "dlm", Lumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centilumen, defined as: decilumen × 1.0/10.0
   /// </summary>
   public static readonly LuminousFlux Centilumen = new ("centilumen", "clm", Decilumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millilumen, defined as: centilumen × 1.0/10.0
   /// </summary>
   public static readonly LuminousFlux Millilumen = new ("millilumen", "mlm", Centilumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microlumen, defined as: millilumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Microlumen = new ("microlumen", "μlm", Millilumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanolumen, defined as: microlumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Nanolumen = new ("nanolumen", "nlm", Microlumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picolumen, defined as: nanolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Picolumen = new ("picolumen", "plm", Nanolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtolumen, defined as: picolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Femtolumen = new ("femtolumen", "flm", Picolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attolumen, defined as: femtolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Attolumen = new ("attolumen", "alm", Femtolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptolumen, defined as: attolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Zeptolumen = new ("zeptolumen", "zlm", Attolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctolumen, defined as: zeptolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Yoctolumen = new ("yoctolumen", "ylm", Zeptolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontolumen, defined as: yoctolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Rontolumen = new ("rontolumen", "rlm", Yoctolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectolumen, defined as: rontolumen × 1.0/1000.0
   /// </summary>
   public static readonly LuminousFlux Quectolumen = new ("quectolumen", "qlm", Rontolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekalumen, defined as: lumen × 10.0
   /// </summary>
   public static readonly LuminousFlux Dekalumen = new ("dekalumen", "dalm", Lumen, 10.0, system: "SI");

   /// <summary>
   /// hectolumen, defined as: dekalumen × 10.0
   /// </summary>
   public static readonly LuminousFlux Hectolumen = new ("hectolumen", "hlm", Dekalumen, 10.0, system: "SI");

   /// <summary>
   /// kilolumen, defined as: hectolumen × 10.0
   /// </summary>
   public static readonly LuminousFlux Kilolumen = new ("kilolumen", "klm", Hectolumen, 10.0, system: "SI");

   /// <summary>
   /// megalumen, defined as: kilolumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Megalumen = new ("megalumen", "Mlm", Kilolumen, 1000.0, system: "SI");

   /// <summary>
   /// gigalumen, defined as: megalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Gigalumen = new ("gigalumen", "Glm", Megalumen, 1000.0, system: "SI");

   /// <summary>
   /// teralumen, defined as: gigalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Teralumen = new ("teralumen", "Tlm", Gigalumen, 1000.0, system: "SI");

   /// <summary>
   /// petalumen, defined as: teralumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Petalumen = new ("petalumen", "Plm", Teralumen, 1000.0, system: "SI");

   /// <summary>
   /// exalumen, defined as: petalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Exalumen = new ("exalumen", "Elm", Petalumen, 1000.0, system: "SI");

   /// <summary>
   /// zettalumen, defined as: exalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Zettalumen = new ("zettalumen", "Zlm", Exalumen, 1000.0, system: "SI");

   /// <summary>
   /// yottalumen, defined as: zettalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Yottalumen = new ("yottalumen", "Ylm", Zettalumen, 1000.0, system: "SI");

   /// <summary>
   /// ronnalumen, defined as: yottalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Ronnalumen = new ("ronnalumen", "Rlm", Yottalumen, 1000.0, system: "SI");

   /// <summary>
   /// quettalumen, defined as: ronnalumen × 1000.0
   /// </summary>
   public static readonly LuminousFlux Quettalumen = new ("quettalumen", "Qlm", Ronnalumen, 1000.0, system: "SI");
}
