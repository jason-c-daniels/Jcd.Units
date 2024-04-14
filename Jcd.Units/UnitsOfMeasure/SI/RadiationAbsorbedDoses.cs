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
   public static readonly RadiationAbsorbedDose Gray = new("gray", "Gy", system: "SI");
   
   /// <summary>
   /// decigray defined such that: gray = dGy × 1.0/10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Decigray = new("decigray", "dGy", Gray, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centigray defined such that: decigray = cGy × 1.0/10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Centigray = new("centigray", "cGy", Decigray, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// milligray defined such that: centigray = mGy × 1.0/10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Milligray = new("milligray", "mGy", Centigray, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microgray defined such that: milligray = μGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Microgray = new("microgray", "μGy", Milligray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanogray defined such that: microgray = nGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Nanogray = new("nanogray", "nGy", Microgray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picogray defined such that: nanogray = pGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Picogray = new("picogray", "pGy", Nanogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtogray defined such that: picogray = fGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Femtogray = new("femtogray", "fGy", Picogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attogray defined such that: femtogray = aGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Attogray = new("attogray", "aGy", Femtogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptogray defined such that: attogray = zGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Zeptogray = new("zeptogray", "zGy", Attogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctogray defined such that: zeptogray = yGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Yoctogray = new("yoctogray", "yGy", Zeptogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontogray defined such that: yoctogray = rGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Rontogray = new("rontogray", "rGy", Yoctogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectogray defined such that: rontogray = qGy × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Quectogray = new("quectogray", "qGy", Rontogray, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekagray defined such that: gray = daGy × 10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Dekagray = new("dekagray", "daGy", Gray, 10.0, system: "SI");
   
   /// <summary>
   /// hectogray defined such that: dekagray = hGy × 10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Hectogray = new("hectogray", "hGy", Dekagray, 10.0, system: "SI");
   
   /// <summary>
   /// kilogray defined such that: hectogray = kGy × 10.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Kilogray = new("kilogray", "kGy", Hectogray, 10.0, system: "SI");
   
   /// <summary>
   /// megagray defined such that: kilogray = MGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Megagray = new("megagray", "MGy", Kilogray, 1000.0, system: "SI");
   
   /// <summary>
   /// gigagray defined such that: megagray = GGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Gigagray = new("gigagray", "GGy", Megagray, 1000.0, system: "SI");
   
   /// <summary>
   /// teragray defined such that: gigagray = TGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Teragray = new("teragray", "TGy", Gigagray, 1000.0, system: "SI");
   
   /// <summary>
   /// petagray defined such that: teragray = PGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Petagray = new("petagray", "PGy", Teragray, 1000.0, system: "SI");
   
   /// <summary>
   /// exagray defined such that: petagray = EGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Exagray = new("exagray", "EGy", Petagray, 1000.0, system: "SI");
   
   /// <summary>
   /// zettagray defined such that: exagray = ZGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Zettagray = new("zettagray", "ZGy", Exagray, 1000.0, system: "SI");
   
   /// <summary>
   /// yottagray defined such that: zettagray = YGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Yottagray = new("yottagray", "YGy", Zettagray, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnagray defined such that: yottagray = RGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Ronnagray = new("ronnagray", "RGy", Yottagray, 1000.0, system: "SI");
   
   /// <summary>
   /// quettagray defined such that: ronnagray = QGy × 1000.0.
   /// </summary>
   public static readonly RadiationAbsorbedDose Quettagray = new("quettagray", "QGy", Ronnagray, 1000.0, system: "SI");
}