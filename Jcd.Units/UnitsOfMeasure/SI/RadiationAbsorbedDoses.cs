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
public class RadiationAbsorbedDoses : Enumeration<RadiationAbsorbedDoses, RadiationAbsorbedDose>
{
   /// <summary>
   /// A(n) gray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Gray = new ("gray", "Gy");

   /// <summary>
   /// A(n) decigray. Defined in terms of a(n) gray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Decigray = new ("decigray", "dGy", Gray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centigray. Defined in terms of a(n) decigray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Centigray = new ("centigray", "cGy", Decigray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milligray. Defined in terms of a(n) centigray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Milligray = new ("milligray", "mGy", Centigray, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microgray. Defined in terms of a(n) milligray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Microgray = new ("microgray", "μGy", Milligray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanogray. Defined in terms of a(n) microgray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Nanogray = new ("nanogray", "nGy", Microgray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picogray. Defined in terms of a(n) nanogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Picogray = new ("picogray", "pGy", Nanogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtogray. Defined in terms of a(n) picogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Femtogray = new ("femtogray", "fGy", Picogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attogray. Defined in terms of a(n) femtogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Attogray = new ("attogray", "aGy", Femtogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptogray. Defined in terms of a(n) attogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Zeptogray = new ("zeptogray", "zGy", Attogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctogray. Defined in terms of a(n) zeptogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Yoctogray = new ("yoctogray", "yGy", Zeptogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontogray. Defined in terms of a(n) yoctogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Rontogray = new ("rontogray", "rGy", Yoctogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectogray. Defined in terms of a(n) rontogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Quectogray = new ("quectogray", "qGy", Rontogray, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekagray. Defined in terms of a(n) gray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Dekagray = new ("dekagray", "daGy", Gray, 10, 0);

   /// <summary>
   /// A(n) hectogray. Defined in terms of a(n) dekagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Hectogray = new ("hectogray", "hGy", Dekagray, 10, 0);

   /// <summary>
   /// A(n) kilogray. Defined in terms of a(n) hectogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Kilogray = new ("kilogray", "kGy", Hectogray, 10, 0);

   /// <summary>
   /// A(n) megagray. Defined in terms of a(n) kilogray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Megagray = new ("megagray", "MGy", Kilogray, 1000, 0);

   /// <summary>
   /// A(n) gigagray. Defined in terms of a(n) megagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Gigagray = new ("gigagray", "GGy", Megagray, 1000, 0);

   /// <summary>
   /// A(n) teragray. Defined in terms of a(n) gigagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Teragray = new ("teragray", "TGy", Gigagray, 1000, 0);

   /// <summary>
   /// A(n) petagray. Defined in terms of a(n) teragray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Petagray = new ("petagray", "PGy", Teragray, 1000, 0);

   /// <summary>
   /// A(n) exagray. Defined in terms of a(n) petagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Exagray = new ("exagray", "EGy", Petagray, 1000, 0);

   /// <summary>
   /// A(n) zettagray. Defined in terms of a(n) exagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Zettagray = new ("zettagray", "ZGy", Exagray, 1000, 0);

   /// <summary>
   /// A(n) yottagray. Defined in terms of a(n) zettagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Yottagray = new ("yottagray", "YGy", Zettagray, 1000, 0);

   /// <summary>
   /// A(n) ronnagray. Defined in terms of a(n) yottagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Ronnagray = new ("ronnagray", "RGy", Yottagray, 1000, 0);

   /// <summary>
   /// A(n) quettagray. Defined in terms of a(n) ronnagray.
   /// </summary>
   public static readonly RadiationAbsorbedDose Quettagray = new ("quettagray", "QGy", Ronnagray, 1000, 0);
}
