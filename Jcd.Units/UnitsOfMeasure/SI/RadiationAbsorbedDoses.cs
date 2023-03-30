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
/// International System of Units for measuring Radiation Absorbed Dose.
/// </summary>
public class RadiationAbsorbedDoses : UnitOfMeasureEnumeration<RadiationAbsorbedDoses, RadiationAbsorbedDose>
{
   /// <summary>
   /// gray, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly RadiationAbsorbedDose Gray = new ("gray", "Gy");

   /// <summary>
   /// decigray, defined as: gray × 1.0/10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Decigray = new ("decigray", "dGy", Gray, 1.0 / 10.0);

   /// <summary>
   /// centigray, defined as: decigray × 1.0/10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Centigray = new ("centigray", "cGy", Decigray, 1.0 / 10.0);

   /// <summary>
   /// milligray, defined as: centigray × 1.0/10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Milligray = new ("milligray", "mGy", Centigray, 1.0 / 10.0);

   /// <summary>
   /// microgray, defined as: milligray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Microgray = new ("microgray", "μGy", Milligray, 1.0 / 1000.0);

   /// <summary>
   /// nanogray, defined as: microgray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Nanogray = new ("nanogray", "nGy", Microgray, 1.0 / 1000.0);

   /// <summary>
   /// picogray, defined as: nanogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Picogray = new ("picogray", "pGy", Nanogray, 1.0 / 1000.0);

   /// <summary>
   /// femtogray, defined as: picogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Femtogray = new ("femtogray", "fGy", Picogray, 1.0 / 1000.0);

   /// <summary>
   /// attogray, defined as: femtogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Attogray = new ("attogray", "aGy", Femtogray, 1.0 / 1000.0);

   /// <summary>
   /// zeptogray, defined as: attogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Zeptogray = new ("zeptogray", "zGy", Attogray, 1.0 / 1000.0);

   /// <summary>
   /// yoctogray, defined as: zeptogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Yoctogray = new ("yoctogray", "yGy", Zeptogray, 1.0 / 1000.0);

   /// <summary>
   /// rontogray, defined as: yoctogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Rontogray = new ("rontogray", "rGy", Yoctogray, 1.0 / 1000.0);

   /// <summary>
   /// quectogray, defined as: rontogray × 1.0/1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Quectogray = new ("quectogray", "qGy", Rontogray, 1.0 / 1000.0);

   /// <summary>
   /// dekagray, defined as: gray × 10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Dekagray = new ("dekagray", "daGy", Gray, 10.0);

   /// <summary>
   /// hectogray, defined as: dekagray × 10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Hectogray = new ("hectogray", "hGy", Dekagray, 10.0);

   /// <summary>
   /// kilogray, defined as: hectogray × 10.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Kilogray = new ("kilogray", "kGy", Hectogray, 10.0);

   /// <summary>
   /// megagray, defined as: kilogray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Megagray = new ("megagray", "MGy", Kilogray, 1000.0);

   /// <summary>
   /// gigagray, defined as: megagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Gigagray = new ("gigagray", "GGy", Megagray, 1000.0);

   /// <summary>
   /// teragray, defined as: gigagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Teragray = new ("teragray", "TGy", Gigagray, 1000.0);

   /// <summary>
   /// petagray, defined as: teragray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Petagray = new ("petagray", "PGy", Teragray, 1000.0);

   /// <summary>
   /// exagray, defined as: petagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Exagray = new ("exagray", "EGy", Petagray, 1000.0);

   /// <summary>
   /// zettagray, defined as: exagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Zettagray = new ("zettagray", "ZGy", Exagray, 1000.0);

   /// <summary>
   /// yottagray, defined as: zettagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Yottagray = new ("yottagray", "YGy", Zettagray, 1000.0);

   /// <summary>
   /// ronnagray, defined as: yottagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Ronnagray = new ("ronnagray", "RGy", Yottagray, 1000.0);

   /// <summary>
   /// quettagray, defined as: ronnagray × 1000.0
   /// </summary>
   public static readonly RadiationAbsorbedDose Quettagray = new ("quettagray", "QGy", Ronnagray, 1000.0);
}
