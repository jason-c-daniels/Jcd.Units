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
   public static readonly LuminousFlux Lumen = new("lumen", "lm", system: "SI");

   /// <summary>
   /// decilumen defined such that: lumen = dlm × 1.0/10.0.
   /// </summary>
   public static readonly LuminousFlux Decilumen = new("decilumen", "dlm", Lumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centilumen defined such that: decilumen = clm × 1.0/10.0.
   /// </summary>
   public static readonly LuminousFlux Centilumen = new("centilumen", "clm", Decilumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millilumen defined such that: centilumen = mlm × 1.0/10.0.
   /// </summary>
   public static readonly LuminousFlux Millilumen = new("millilumen", "mlm", Centilumen, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microlumen defined such that: millilumen = μlm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Microlumen = new("microlumen", "μlm", Millilumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanolumen defined such that: microlumen = nlm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Nanolumen = new("nanolumen", "nlm", Microlumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picolumen defined such that: nanolumen = plm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Picolumen = new("picolumen", "plm", Nanolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtolumen defined such that: picolumen = flm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Femtolumen = new("femtolumen", "flm", Picolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attolumen defined such that: femtolumen = alm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Attolumen = new("attolumen", "alm", Femtolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptolumen defined such that: attolumen = zlm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Zeptolumen = new("zeptolumen", "zlm", Attolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctolumen defined such that: zeptolumen = ylm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Yoctolumen = new("yoctolumen", "ylm", Zeptolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontolumen defined such that: yoctolumen = rlm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Rontolumen = new("rontolumen", "rlm", Yoctolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectolumen defined such that: rontolumen = qlm × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousFlux Quectolumen = new("quectolumen", "qlm", Rontolumen, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekalumen defined such that: lumen = dalm × 10.0.
   /// </summary>
   public static readonly LuminousFlux Dekalumen = new("dekalumen", "dalm", Lumen, 10.0, system: "SI");

   /// <summary>
   /// hectolumen defined such that: dekalumen = hlm × 10.0.
   /// </summary>
   public static readonly LuminousFlux Hectolumen = new("hectolumen", "hlm", Dekalumen, 10.0, system: "SI");

   /// <summary>
   /// kilolumen defined such that: hectolumen = klm × 10.0.
   /// </summary>
   public static readonly LuminousFlux Kilolumen = new("kilolumen", "klm", Hectolumen, 10.0, system: "SI");

   /// <summary>
   /// megalumen defined such that: kilolumen = Mlm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Megalumen = new("megalumen", "Mlm", Kilolumen, 1000.0, system: "SI");

   /// <summary>
   /// gigalumen defined such that: megalumen = Glm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Gigalumen = new("gigalumen", "Glm", Megalumen, 1000.0, system: "SI");

   /// <summary>
   /// teralumen defined such that: gigalumen = Tlm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Teralumen = new("teralumen", "Tlm", Gigalumen, 1000.0, system: "SI");

   /// <summary>
   /// petalumen defined such that: teralumen = Plm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Petalumen = new("petalumen", "Plm", Teralumen, 1000.0, system: "SI");

   /// <summary>
   /// exalumen defined such that: petalumen = Elm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Exalumen = new("exalumen", "Elm", Petalumen, 1000.0, system: "SI");

   /// <summary>
   /// zettalumen defined such that: exalumen = Zlm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Zettalumen = new("zettalumen", "Zlm", Exalumen, 1000.0, system: "SI");

   /// <summary>
   /// yottalumen defined such that: zettalumen = Ylm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Yottalumen = new("yottalumen", "Ylm", Zettalumen, 1000.0, system: "SI");

   /// <summary>
   /// ronnalumen defined such that: yottalumen = Rlm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Ronnalumen = new("ronnalumen", "Rlm", Yottalumen, 1000.0, system: "SI");

   /// <summary>
   /// quettalumen defined such that: ronnalumen = Qlm × 1000.0.
   /// </summary>
   public static readonly LuminousFlux Quettalumen = new("quettalumen", "Qlm", Ronnalumen, 1000.0, system: "SI");
}