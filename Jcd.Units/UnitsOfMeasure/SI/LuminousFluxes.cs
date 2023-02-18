using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class LuminousFluxes : Enumeration<LuminousFluxes,LuminousFlux>
{
    public static readonly LuminousFlux Lumen = new ("lumen", "lm");
    public static readonly LuminousFlux Decilumen = new ("decilumen", "dlm", Lumen, 1.0/10.0,0);
    public static readonly LuminousFlux Centilumen = new ("centilumen", "clm", Decilumen, 1.0/10.0,0);
    public static readonly LuminousFlux Millilumen = new ("millilumen", "mlm", Centilumen, 1.0/10.0,0);
    public static readonly LuminousFlux Microlumen = new ("microlumen", "μlm", Millilumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Nanolumen = new ("nanolumen", "nlm", Microlumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Picolumen = new ("picolumen", "plm", Nanolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Femtolumen = new ("femtolumen", "flm", Picolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Attolumen = new ("attolumen", "alm", Femtolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Zeptolumen = new ("zeptolumen", "zlm", Attolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Yoctolumen = new ("yoctolumen", "ylm", Zeptolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Rontolumen = new ("rontolumen", "rlm", Yoctolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Quectolumen = new ("quectolumen", "qlm", Rontolumen, 1.0/1000.0,0);
    public static readonly LuminousFlux Dekalumen = new ("dekalumen", "dalm", Lumen, 10,0);
    public static readonly LuminousFlux Hectolumen = new ("hectolumen", "hlm", Dekalumen, 10,0);
    public static readonly LuminousFlux Kilolumen = new ("kilolumen", "klm", Hectolumen, 10,0);
    public static readonly LuminousFlux Megalumen = new ("megalumen", "Mlm", Kilolumen, 1000,0);
    public static readonly LuminousFlux Gigalumen = new ("gigalumen", "Glm", Megalumen, 1000,0);
    public static readonly LuminousFlux Teralumen = new ("teralumen", "Tlm", Gigalumen, 1000,0);
    public static readonly LuminousFlux Petalumen = new ("petalumen", "Plm", Teralumen, 1000,0);
    public static readonly LuminousFlux Exalumen = new ("exalumen", "Elm", Petalumen, 1000,0);
    public static readonly LuminousFlux Zettalumen = new ("zettalumen", "Zlm", Exalumen, 1000,0);
    public static readonly LuminousFlux Yottalumen = new ("yottalumen", "Ylm", Zettalumen, 1000,0);
    public static readonly LuminousFlux Ronnalumen = new ("ronnalumen", "Rlm", Yottalumen, 1000,0);
    public static readonly LuminousFlux Quettalumen = new ("quettalumen", "Qlm", Ronnalumen, 1000,0);
}