using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Luminous Flux.
/// </summary>
public class LuminousFluxes : Enumeration<LuminousFluxes,LuminousFlux>
{


    /// <summary>
    /// A(n) lumen.
    /// </summary>
    public static readonly LuminousFlux Lumen = new ("lumen", "lm");
    /// <summary>
    /// A(n) decilumen. Defined in terms of a(n) lumen.
    /// </summary>
    public static readonly LuminousFlux Decilumen = new ("decilumen", "dlm", Lumen, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centilumen. Defined in terms of a(n) decilumen.
    /// </summary>
    public static readonly LuminousFlux Centilumen = new ("centilumen", "clm", Decilumen, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millilumen. Defined in terms of a(n) centilumen.
    /// </summary>
    public static readonly LuminousFlux Millilumen = new ("millilumen", "mlm", Centilumen, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microlumen. Defined in terms of a(n) millilumen.
    /// </summary>
    public static readonly LuminousFlux Microlumen = new ("microlumen", "μlm", Millilumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanolumen. Defined in terms of a(n) microlumen.
    /// </summary>
    public static readonly LuminousFlux Nanolumen = new ("nanolumen", "nlm", Microlumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picolumen. Defined in terms of a(n) nanolumen.
    /// </summary>
    public static readonly LuminousFlux Picolumen = new ("picolumen", "plm", Nanolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtolumen. Defined in terms of a(n) picolumen.
    /// </summary>
    public static readonly LuminousFlux Femtolumen = new ("femtolumen", "flm", Picolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attolumen. Defined in terms of a(n) femtolumen.
    /// </summary>
    public static readonly LuminousFlux Attolumen = new ("attolumen", "alm", Femtolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptolumen. Defined in terms of a(n) attolumen.
    /// </summary>
    public static readonly LuminousFlux Zeptolumen = new ("zeptolumen", "zlm", Attolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctolumen. Defined in terms of a(n) zeptolumen.
    /// </summary>
    public static readonly LuminousFlux Yoctolumen = new ("yoctolumen", "ylm", Zeptolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontolumen. Defined in terms of a(n) yoctolumen.
    /// </summary>
    public static readonly LuminousFlux Rontolumen = new ("rontolumen", "rlm", Yoctolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectolumen. Defined in terms of a(n) rontolumen.
    /// </summary>
    public static readonly LuminousFlux Quectolumen = new ("quectolumen", "qlm", Rontolumen, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekalumen. Defined in terms of a(n) lumen.
    /// </summary>
    public static readonly LuminousFlux Dekalumen = new ("dekalumen", "dalm", Lumen, 10,0);
    
    /// <summary>
    /// A(n) hectolumen. Defined in terms of a(n) dekalumen.
    /// </summary>
    public static readonly LuminousFlux Hectolumen = new ("hectolumen", "hlm", Dekalumen, 10,0);
    
    /// <summary>
    /// A(n) kilolumen. Defined in terms of a(n) hectolumen.
    /// </summary>
    public static readonly LuminousFlux Kilolumen = new ("kilolumen", "klm", Hectolumen, 10,0);
    
    /// <summary>
    /// A(n) megalumen. Defined in terms of a(n) kilolumen.
    /// </summary>
    public static readonly LuminousFlux Megalumen = new ("megalumen", "Mlm", Kilolumen, 1000,0);
    
    /// <summary>
    /// A(n) gigalumen. Defined in terms of a(n) megalumen.
    /// </summary>
    public static readonly LuminousFlux Gigalumen = new ("gigalumen", "Glm", Megalumen, 1000,0);
    
    /// <summary>
    /// A(n) teralumen. Defined in terms of a(n) gigalumen.
    /// </summary>
    public static readonly LuminousFlux Teralumen = new ("teralumen", "Tlm", Gigalumen, 1000,0);
    
    /// <summary>
    /// A(n) petalumen. Defined in terms of a(n) teralumen.
    /// </summary>
    public static readonly LuminousFlux Petalumen = new ("petalumen", "Plm", Teralumen, 1000,0);
    
    /// <summary>
    /// A(n) exalumen. Defined in terms of a(n) petalumen.
    /// </summary>
    public static readonly LuminousFlux Exalumen = new ("exalumen", "Elm", Petalumen, 1000,0);
    
    /// <summary>
    /// A(n) zettalumen. Defined in terms of a(n) exalumen.
    /// </summary>
    public static readonly LuminousFlux Zettalumen = new ("zettalumen", "Zlm", Exalumen, 1000,0);
    
    /// <summary>
    /// A(n) yottalumen. Defined in terms of a(n) zettalumen.
    /// </summary>
    public static readonly LuminousFlux Yottalumen = new ("yottalumen", "Ylm", Zettalumen, 1000,0);
    
    /// <summary>
    /// A(n) ronnalumen. Defined in terms of a(n) yottalumen.
    /// </summary>
    public static readonly LuminousFlux Ronnalumen = new ("ronnalumen", "Rlm", Yottalumen, 1000,0);
    
    /// <summary>
    /// A(n) quettalumen. Defined in terms of a(n) ronnalumen.
    /// </summary>
    public static readonly LuminousFlux Quettalumen = new ("quettalumen", "Qlm", Ronnalumen, 1000,0);

}