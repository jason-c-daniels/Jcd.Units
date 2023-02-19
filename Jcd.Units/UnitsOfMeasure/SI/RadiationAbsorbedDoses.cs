using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radiation Absorbed Dose.
/// </summary>
public class RadiationAbsorbedDoses : Enumeration<RadiationAbsorbedDoses,RadiationAbsorbedDose>
{

    /// <summary>
    /// Units of a gray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Gray = new ("gray", "Gy");
    /// <summary>
    /// Units of a decigray. It's defined in terms of a(n) SI gray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Decigray = new ("decigray", "dGy", Gray, 1.0/10.0,0);
    /// <summary>
    /// Units of a centigray. It's defined in terms of a(n) SI decigray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Centigray = new ("centigray", "cGy", Decigray, 1.0/10.0,0);
    /// <summary>
    /// Units of a milligray. It's defined in terms of a(n) SI centigray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Milligray = new ("milligray", "mGy", Centigray, 1.0/10.0,0);
    /// <summary>
    /// Units of a microgray. It's defined in terms of a(n) SI milligray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Microgray = new ("microgray", "μGy", Milligray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanogray. It's defined in terms of a(n) SI microgray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Nanogray = new ("nanogray", "nGy", Microgray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picogray. It's defined in terms of a(n) SI nanogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Picogray = new ("picogray", "pGy", Nanogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtogray. It's defined in terms of a(n) SI picogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Femtogray = new ("femtogray", "fGy", Picogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attogray. It's defined in terms of a(n) SI femtogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Attogray = new ("attogray", "aGy", Femtogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptogray. It's defined in terms of a(n) SI attogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Zeptogray = new ("zeptogray", "zGy", Attogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctogray. It's defined in terms of a(n) SI zeptogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Yoctogray = new ("yoctogray", "yGy", Zeptogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontogray. It's defined in terms of a(n) SI yoctogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Rontogray = new ("rontogray", "rGy", Yoctogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectogray. It's defined in terms of a(n) SI rontogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Quectogray = new ("quectogray", "qGy", Rontogray, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekagray. It's defined in terms of a(n) SI gray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Dekagray = new ("dekagray", "daGy", Gray, 10,0);
    /// <summary>
    /// Units of a hectogray. It's defined in terms of a(n) SI dekagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Hectogray = new ("hectogray", "hGy", Dekagray, 10,0);
    /// <summary>
    /// Units of a kilogray. It's defined in terms of a(n) SI hectogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Kilogray = new ("kilogray", "kGy", Hectogray, 10,0);
    /// <summary>
    /// Units of a megagray. It's defined in terms of a(n) SI kilogray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Megagray = new ("megagray", "MGy", Kilogray, 1000,0);
    /// <summary>
    /// Units of a gigagray. It's defined in terms of a(n) SI megagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Gigagray = new ("gigagray", "GGy", Megagray, 1000,0);
    /// <summary>
    /// Units of a teragray. It's defined in terms of a(n) SI gigagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Teragray = new ("teragray", "TGy", Gigagray, 1000,0);
    /// <summary>
    /// Units of a petagray. It's defined in terms of a(n) SI teragray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Petagray = new ("petagray", "PGy", Teragray, 1000,0);
    /// <summary>
    /// Units of a exagray. It's defined in terms of a(n) SI petagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Exagray = new ("exagray", "EGy", Petagray, 1000,0);
    /// <summary>
    /// Units of a zettagray. It's defined in terms of a(n) SI exagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Zettagray = new ("zettagray", "ZGy", Exagray, 1000,0);
    /// <summary>
    /// Units of a yottagray. It's defined in terms of a(n) SI zettagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Yottagray = new ("yottagray", "YGy", Zettagray, 1000,0);
    /// <summary>
    /// Units of a ronnagray. It's defined in terms of a(n) SI yottagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Ronnagray = new ("ronnagray", "RGy", Yottagray, 1000,0);
    /// <summary>
    /// Units of a quettagray. It's defined in terms of a(n) SI ronnagray.
    /// </summary>
    public static readonly RadiationAbsorbedDose Quettagray = new ("quettagray", "QGy", Ronnagray, 1000,0);

}