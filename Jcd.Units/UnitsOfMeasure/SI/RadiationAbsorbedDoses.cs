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
   /// A(n) gray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Gray = new ("gray", "Gy");

   /// <summary>
   /// A(n) decigray. Defined as: (1.0/10.0) × gray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Decigray = new ("decigray", "dGy", Gray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centigray. Defined as: (1.0/10.0) × decigray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Centigray = new ("centigray", "cGy", Decigray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milligray. Defined as: (1.0/10.0) × centigray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Milligray = new ("milligray", "mGy", Centigray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microgray. Defined as: (1.0/1000.0) × milligray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Microgray = new ("microgray", "μGy", Milligray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanogray. Defined as: (1.0/1000.0) × microgray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Nanogray = new ("nanogray", "nGy", Microgray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picogray. Defined as: (1.0/1000.0) × nanogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Picogray = new ("picogray", "pGy", Nanogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtogray. Defined as: (1.0/1000.0) × picogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Femtogray = new ("femtogray", "fGy", Picogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attogray. Defined as: (1.0/1000.0) × femtogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Attogray = new ("attogray", "aGy", Femtogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptogray. Defined as: (1.0/1000.0) × attogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Zeptogray = new ("zeptogray", "zGy", Attogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctogray. Defined as: (1.0/1000.0) × zeptogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Yoctogray = new ("yoctogray", "yGy", Zeptogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontogray. Defined as: (1.0/1000.0) × yoctogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Rontogray = new ("rontogray", "rGy", Yoctogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectogray. Defined as: (1.0/1000.0) × rontogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Quectogray = new ("quectogray", "qGy", Rontogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekagray. Defined as: (10.0) × gray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Dekagray = new ("dekagray", "daGy", Gray, 10.0, 0);

   /// <summary>
   /// A(n) hectogray. Defined as: (10.0) × dekagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Hectogray = new ("hectogray", "hGy", Dekagray, 10.0, 0);

   /// <summary>
   /// A(n) kilogray. Defined as: (10.0) × hectogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Kilogray = new ("kilogray", "kGy", Hectogray, 10.0, 0);

   /// <summary>
   /// A(n) megagray. Defined as: (1000.0) × kilogray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Megagray = new ("megagray", "MGy", Kilogray, 1000.0, 0);

   /// <summary>
   /// A(n) gigagray. Defined as: (1000.0) × megagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Gigagray = new ("gigagray", "GGy", Megagray, 1000.0, 0);

   /// <summary>
   /// A(n) teragray. Defined as: (1000.0) × gigagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Teragray = new ("teragray", "TGy", Gigagray, 1000.0, 0);

   /// <summary>
   /// A(n) petagray. Defined as: (1000.0) × teragray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Petagray = new ("petagray", "PGy", Teragray, 1000.0, 0);

   /// <summary>
   /// A(n) exagray. Defined as: (1000.0) × petagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Exagray = new ("exagray", "EGy", Petagray, 1000.0, 0);

   /// <summary>
   /// A(n) zettagray. Defined as: (1000.0) × exagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Zettagray = new ("zettagray", "ZGy", Exagray, 1000.0, 0);

   /// <summary>
   /// A(n) yottagray. Defined as: (1000.0) × zettagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Yottagray = new ("yottagray", "YGy", Zettagray, 1000.0, 0);

   /// <summary>
   /// A(n) ronnagray. Defined as: (1000.0) × yottagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Ronnagray = new ("ronnagray", "RGy", Yottagray, 1000.0, 0);

   /// <summary>
   /// A(n) quettagray. Defined as: (1000.0) × ronnagray + (0).
   /// </summary>
   public static readonly RadiationAbsorbedDose Quettagray = new ("quettagray", "QGy", Ronnagray, 1000.0, 0);
}
