using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radiation Absorbed Dose.
/// </summary>
public class RadiationAbsorbedDoses : Enumeration<RadiationAbsorbedDoses,RadiationAbsorbedDose>
{
    public static readonly RadiationAbsorbedDose Gray = new ("gray", "Gy");
    public static readonly RadiationAbsorbedDose Decigray = new ("decigray", "dGy", Gray, 1.0/10.0,0);
    public static readonly RadiationAbsorbedDose Centigray = new ("centigray", "cGy", Decigray, 1.0/10.0,0);
    public static readonly RadiationAbsorbedDose Milligray = new ("milligray", "mGy", Centigray, 1.0/10.0,0);
    public static readonly RadiationAbsorbedDose Microgray = new ("microgray", "μGy", Milligray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Nanogray = new ("nanogray", "nGy", Microgray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Picogray = new ("picogray", "pGy", Nanogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Femtogray = new ("femtogray", "fGy", Picogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Attogray = new ("attogray", "aGy", Femtogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Zeptogray = new ("zeptogray", "zGy", Attogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Yoctogray = new ("yoctogray", "yGy", Zeptogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Rontogray = new ("rontogray", "rGy", Yoctogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Quectogray = new ("quectogray", "qGy", Rontogray, 1.0/1000.0,0);
    public static readonly RadiationAbsorbedDose Dekagray = new ("dekagray", "daGy", Gray, 10,0);
    public static readonly RadiationAbsorbedDose Hectogray = new ("hectogray", "hGy", Dekagray, 10,0);
    public static readonly RadiationAbsorbedDose Kilogray = new ("kilogray", "kGy", Hectogray, 10,0);
    public static readonly RadiationAbsorbedDose Megagray = new ("megagray", "MGy", Kilogray, 1000,0);
    public static readonly RadiationAbsorbedDose Gigagray = new ("gigagray", "GGy", Megagray, 1000,0);
    public static readonly RadiationAbsorbedDose Teragray = new ("teragray", "TGy", Gigagray, 1000,0);
    public static readonly RadiationAbsorbedDose Petagray = new ("petagray", "PGy", Teragray, 1000,0);
    public static readonly RadiationAbsorbedDose Exagray = new ("exagray", "EGy", Petagray, 1000,0);
    public static readonly RadiationAbsorbedDose Zettagray = new ("zettagray", "ZGy", Exagray, 1000,0);
    public static readonly RadiationAbsorbedDose Yottagray = new ("yottagray", "YGy", Zettagray, 1000,0);
    public static readonly RadiationAbsorbedDose Ronnagray = new ("ronnagray", "RGy", Yottagray, 1000,0);
    public static readonly RadiationAbsorbedDose Quettagray = new ("quettagray", "QGy", Ronnagray, 1000,0);
}