using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Luminous Flux.
/// </summary>
public class LuminousFluxes : Enumeration<LuminousFluxes,LuminousFlux>
{

    /// <summary>
    /// Units of a lumen.
    /// </summary>
    public static readonly LuminousFlux Lumen = new ("lumen", "lm");
    /// <summary>
    /// Units of a decilumen. It's defined in terms of a(n) SI lumen.
    /// </summary>
    public static readonly LuminousFlux Decilumen = new ("decilumen", "dlm", Lumen, 1.0/10.0,0);
    /// <summary>
    /// Units of a centilumen. It's defined in terms of a(n) SI decilumen.
    /// </summary>
    public static readonly LuminousFlux Centilumen = new ("centilumen", "clm", Decilumen, 1.0/10.0,0);
    /// <summary>
    /// Units of a millilumen. It's defined in terms of a(n) SI centilumen.
    /// </summary>
    public static readonly LuminousFlux Millilumen = new ("millilumen", "mlm", Centilumen, 1.0/10.0,0);
    /// <summary>
    /// Units of a microlumen. It's defined in terms of a(n) SI millilumen.
    /// </summary>
    public static readonly LuminousFlux Microlumen = new ("microlumen", "μlm", Millilumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanolumen. It's defined in terms of a(n) SI microlumen.
    /// </summary>
    public static readonly LuminousFlux Nanolumen = new ("nanolumen", "nlm", Microlumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picolumen. It's defined in terms of a(n) SI nanolumen.
    /// </summary>
    public static readonly LuminousFlux Picolumen = new ("picolumen", "plm", Nanolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtolumen. It's defined in terms of a(n) SI picolumen.
    /// </summary>
    public static readonly LuminousFlux Femtolumen = new ("femtolumen", "flm", Picolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attolumen. It's defined in terms of a(n) SI femtolumen.
    /// </summary>
    public static readonly LuminousFlux Attolumen = new ("attolumen", "alm", Femtolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptolumen. It's defined in terms of a(n) SI attolumen.
    /// </summary>
    public static readonly LuminousFlux Zeptolumen = new ("zeptolumen", "zlm", Attolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctolumen. It's defined in terms of a(n) SI zeptolumen.
    /// </summary>
    public static readonly LuminousFlux Yoctolumen = new ("yoctolumen", "ylm", Zeptolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontolumen. It's defined in terms of a(n) SI yoctolumen.
    /// </summary>
    public static readonly LuminousFlux Rontolumen = new ("rontolumen", "rlm", Yoctolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectolumen. It's defined in terms of a(n) SI rontolumen.
    /// </summary>
    public static readonly LuminousFlux Quectolumen = new ("quectolumen", "qlm", Rontolumen, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekalumen. It's defined in terms of a(n) SI lumen.
    /// </summary>
    public static readonly LuminousFlux Dekalumen = new ("dekalumen", "dalm", Lumen, 10,0);
    /// <summary>
    /// Units of a hectolumen. It's defined in terms of a(n) SI dekalumen.
    /// </summary>
    public static readonly LuminousFlux Hectolumen = new ("hectolumen", "hlm", Dekalumen, 10,0);
    /// <summary>
    /// Units of a kilolumen. It's defined in terms of a(n) SI hectolumen.
    /// </summary>
    public static readonly LuminousFlux Kilolumen = new ("kilolumen", "klm", Hectolumen, 10,0);
    /// <summary>
    /// Units of a megalumen. It's defined in terms of a(n) SI kilolumen.
    /// </summary>
    public static readonly LuminousFlux Megalumen = new ("megalumen", "Mlm", Kilolumen, 1000,0);
    /// <summary>
    /// Units of a gigalumen. It's defined in terms of a(n) SI megalumen.
    /// </summary>
    public static readonly LuminousFlux Gigalumen = new ("gigalumen", "Glm", Megalumen, 1000,0);
    /// <summary>
    /// Units of a teralumen. It's defined in terms of a(n) SI gigalumen.
    /// </summary>
    public static readonly LuminousFlux Teralumen = new ("teralumen", "Tlm", Gigalumen, 1000,0);
    /// <summary>
    /// Units of a petalumen. It's defined in terms of a(n) SI teralumen.
    /// </summary>
    public static readonly LuminousFlux Petalumen = new ("petalumen", "Plm", Teralumen, 1000,0);
    /// <summary>
    /// Units of a exalumen. It's defined in terms of a(n) SI petalumen.
    /// </summary>
    public static readonly LuminousFlux Exalumen = new ("exalumen", "Elm", Petalumen, 1000,0);
    /// <summary>
    /// Units of a zettalumen. It's defined in terms of a(n) SI exalumen.
    /// </summary>
    public static readonly LuminousFlux Zettalumen = new ("zettalumen", "Zlm", Exalumen, 1000,0);
    /// <summary>
    /// Units of a yottalumen. It's defined in terms of a(n) SI zettalumen.
    /// </summary>
    public static readonly LuminousFlux Yottalumen = new ("yottalumen", "Ylm", Zettalumen, 1000,0);
    /// <summary>
    /// Units of a ronnalumen. It's defined in terms of a(n) SI yottalumen.
    /// </summary>
    public static readonly LuminousFlux Ronnalumen = new ("ronnalumen", "Rlm", Yottalumen, 1000,0);
    /// <summary>
    /// Units of a quettalumen. It's defined in terms of a(n) SI ronnalumen.
    /// </summary>
    public static readonly LuminousFlux Quettalumen = new ("quettalumen", "Qlm", Ronnalumen, 1000,0);

}