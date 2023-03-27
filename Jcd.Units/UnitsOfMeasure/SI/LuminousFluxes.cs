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
   /// A(n) lumen.
   /// </summary>
   public static readonly LuminousFlux Lumen = new ("lumen", "lm");

   /// <summary>
   /// A(n) decilumen. Defined as: (1.0/10.0) × lumen + (0).
   /// </summary>
   public static readonly LuminousFlux Decilumen = new ("decilumen", "dlm", Lumen, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centilumen. Defined as: (1.0/10.0) × decilumen + (0).
   /// </summary>
   public static readonly LuminousFlux Centilumen = new ("centilumen", "clm", Decilumen, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millilumen. Defined as: (1.0/10.0) × centilumen + (0).
   /// </summary>
   public static readonly LuminousFlux Millilumen = new ("millilumen", "mlm", Centilumen, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microlumen. Defined as: (1.0/1000.0) × millilumen + (0).
   /// </summary>
   public static readonly LuminousFlux Microlumen = new ("microlumen", "μlm", Millilumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanolumen. Defined as: (1.0/1000.0) × microlumen + (0).
   /// </summary>
   public static readonly LuminousFlux Nanolumen = new ("nanolumen", "nlm", Microlumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picolumen. Defined as: (1.0/1000.0) × nanolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Picolumen = new ("picolumen", "plm", Nanolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtolumen. Defined as: (1.0/1000.0) × picolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Femtolumen = new ("femtolumen", "flm", Picolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attolumen. Defined as: (1.0/1000.0) × femtolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Attolumen = new ("attolumen", "alm", Femtolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptolumen. Defined as: (1.0/1000.0) × attolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Zeptolumen = new ("zeptolumen", "zlm", Attolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctolumen. Defined as: (1.0/1000.0) × zeptolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Yoctolumen = new ("yoctolumen", "ylm", Zeptolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontolumen. Defined as: (1.0/1000.0) × yoctolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Rontolumen = new ("rontolumen", "rlm", Yoctolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectolumen. Defined as: (1.0/1000.0) × rontolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Quectolumen = new ("quectolumen", "qlm", Rontolumen, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekalumen. Defined as: (10.0) × lumen + (0).
   /// </summary>
   public static readonly LuminousFlux Dekalumen = new ("dekalumen", "dalm", Lumen, 10.0, 0);

   /// <summary>
   /// A(n) hectolumen. Defined as: (10.0) × dekalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Hectolumen = new ("hectolumen", "hlm", Dekalumen, 10.0, 0);

   /// <summary>
   /// A(n) kilolumen. Defined as: (10.0) × hectolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Kilolumen = new ("kilolumen", "klm", Hectolumen, 10.0, 0);

   /// <summary>
   /// A(n) megalumen. Defined as: (1000.0) × kilolumen + (0).
   /// </summary>
   public static readonly LuminousFlux Megalumen = new ("megalumen", "Mlm", Kilolumen, 1000.0, 0);

   /// <summary>
   /// A(n) gigalumen. Defined as: (1000.0) × megalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Gigalumen = new ("gigalumen", "Glm", Megalumen, 1000.0, 0);

   /// <summary>
   /// A(n) teralumen. Defined as: (1000.0) × gigalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Teralumen = new ("teralumen", "Tlm", Gigalumen, 1000.0, 0);

   /// <summary>
   /// A(n) petalumen. Defined as: (1000.0) × teralumen + (0).
   /// </summary>
   public static readonly LuminousFlux Petalumen = new ("petalumen", "Plm", Teralumen, 1000.0, 0);

   /// <summary>
   /// A(n) exalumen. Defined as: (1000.0) × petalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Exalumen = new ("exalumen", "Elm", Petalumen, 1000.0, 0);

   /// <summary>
   /// A(n) zettalumen. Defined as: (1000.0) × exalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Zettalumen = new ("zettalumen", "Zlm", Exalumen, 1000.0, 0);

   /// <summary>
   /// A(n) yottalumen. Defined as: (1000.0) × zettalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Yottalumen = new ("yottalumen", "Ylm", Zettalumen, 1000.0, 0);

   /// <summary>
   /// A(n) ronnalumen. Defined as: (1000.0) × yottalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Ronnalumen = new ("ronnalumen", "Rlm", Yottalumen, 1000.0, 0);

   /// <summary>
   /// A(n) quettalumen. Defined as: (1000.0) × ronnalumen + (0).
   /// </summary>
   public static readonly LuminousFlux Quettalumen = new ("quettalumen", "Qlm", Ronnalumen, 1000.0, 0);
}
