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
/// International System of Units for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// cubic meter, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Volume CubicMeter = new("cubic meter", "m³", system: "SI");

   /// <summary>
   /// cubic decimeter defined such that: cubic meter = dm³ × (1.0/10.0)*(1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Volume CubicDecimeter = new("cubic decimeter", "dm³", CubicMeter, 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0), system: "SI");

   /// <summary>
   /// cubic centimeter defined such that: cubic decimeter = cm³ × (1.0/10.0)*(1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Volume CubicCentimeter = new("cubic centimeter", "cm³", CubicDecimeter, 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0), system: "SI");

   /// <summary>
   /// cubic millimeter defined such that: cubic centimeter = mm³ × (1.0/10.0)*(1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Volume CubicMillimeter = new("cubic millimeter", "mm³", CubicCentimeter, 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0), system: "SI");

   /// <summary>
   /// cubic micrometer defined such that: cubic millimeter = μm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicMicrometer = new("cubic micrometer", "μm³", CubicMillimeter, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic nanometer defined such that: cubic micrometer = nm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicNanometer = new("cubic nanometer", "nm³", CubicMicrometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic picometer defined such that: cubic nanometer = pm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicPicometer = new("cubic picometer", "pm³", CubicNanometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic femtometer defined such that: cubic picometer = fm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicFemtometer = new("cubic femtometer", "fm³", CubicPicometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic attometer defined such that: cubic femtometer = am³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicAttometer = new("cubic attometer", "am³", CubicFemtometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic zeptometer defined such that: cubic attometer = zm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicZeptometer = new("cubic zeptometer", "zm³", CubicAttometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic yoctometer defined such that: cubic zeptometer = ym³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicYoctometer = new("cubic yoctometer", "ym³", CubicZeptometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic rontometer defined such that: cubic yoctometer = rm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicRontometer = new("cubic rontometer", "rm³", CubicYoctometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic quectometer defined such that: cubic rontometer = qm³ × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Volume CubicQuectometer = new("cubic quectometer", "qm³", CubicRontometer, 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0), system: "SI");

   /// <summary>
   /// cubic dekameter defined such that: cubic meter = dam³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicDekameter = new("cubic dekameter", "dam³", CubicMeter, 10.0 * 10.0 * 10.0, system: "SI");

   /// <summary>
   /// cubic hectometer defined such that: cubic dekameter = hm³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicHectometer = new("cubic hectometer", "hm³", CubicDekameter, 10.0 * 10.0 * 10.0, system: "SI");

   /// <summary>
   /// cubic kilometer defined such that: cubic hectometer = km³ × (10.0)*(10.0)*(10.0).
   /// </summary>
   public static readonly Volume CubicKilometer = new("cubic kilometer", "km³", CubicHectometer, 10.0 * 10.0 * 10.0, system: "SI");

   /// <summary>
   /// cubic megameter defined such that: cubic kilometer = Mm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicMegameter = new("cubic megameter", "Mm³", CubicKilometer, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic gigameter defined such that: cubic megameter = Gm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicGigameter = new("cubic gigameter", "Gm³", CubicMegameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic terameter defined such that: cubic gigameter = Tm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicTerameter = new("cubic terameter", "Tm³", CubicGigameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic petameter defined such that: cubic terameter = Pm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicPetameter = new("cubic petameter", "Pm³", CubicTerameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic exameter defined such that: cubic petameter = Em³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicExameter = new("cubic exameter", "Em³", CubicPetameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic zettameter defined such that: cubic exameter = Zm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicZettameter = new("cubic zettameter", "Zm³", CubicExameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic yottameter defined such that: cubic zettameter = Ym³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicYottameter = new("cubic yottameter", "Ym³", CubicZettameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic ronnameter defined such that: cubic yottameter = Rm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicRonnameter = new("cubic ronnameter", "Rm³", CubicYottameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// cubic quettameter defined such that: cubic ronnameter = Qm³ × (1000.0)*(1000.0)*(1000.0).
   /// </summary>
   public static readonly Volume CubicQuettameter = new("cubic quettameter", "Qm³", CubicRonnameter, 1000.0 * 1000.0 * 1000.0, system: "SI");

   /// <summary>
   /// liter is a synonym for cubic decimeter
   /// </summary>
   public static readonly Volume Liter = new("liter", "L", CubicDecimeter, system: "SI");

   /// <summary>
   /// deciliter defined such that: liter = dL × 1.0/10.0.
   /// </summary>
   public static readonly Volume Deciliter = new("deciliter", "dL", Liter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiliter defined such that: deciliter = cL × 1.0/10.0.
   /// </summary>
   public static readonly Volume Centiliter = new("centiliter", "cL", Deciliter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliliter defined such that: centiliter = mL × 1.0/10.0.
   /// </summary>
   public static readonly Volume Milliliter = new("milliliter", "mL", Centiliter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microliter defined such that: milliliter = μL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Microliter = new("microliter", "μL", Milliliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanoliter defined such that: microliter = nL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Nanoliter = new("nanoliter", "nL", Microliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picoliter defined such that: nanoliter = pL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Picoliter = new("picoliter", "pL", Nanoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtoliter defined such that: picoliter = fL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Femtoliter = new("femtoliter", "fL", Picoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attoliter defined such that: femtoliter = aL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Attoliter = new("attoliter", "aL", Femtoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptoliter defined such that: attoliter = zL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Zeptoliter = new("zeptoliter", "zL", Attoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctoliter defined such that: zeptoliter = yL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Yoctoliter = new("yoctoliter", "yL", Zeptoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontoliter defined such that: yoctoliter = rL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Rontoliter = new("rontoliter", "rL", Yoctoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectoliter defined such that: rontoliter = qL × 1.0/1000.0.
   /// </summary>
   public static readonly Volume Quectoliter = new("quectoliter", "qL", Rontoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekaliter defined such that: liter = daL × 10.0.
   /// </summary>
   public static readonly Volume Dekaliter = new("dekaliter", "daL", Liter, 10.0, system: "SI");

   /// <summary>
   /// hectoliter defined such that: dekaliter = hL × 10.0.
   /// </summary>
   public static readonly Volume Hectoliter = new("hectoliter", "hL", Dekaliter, 10.0, system: "SI");

   /// <summary>
   /// kiloliter defined such that: hectoliter = kL × 10.0.
   /// </summary>
   public static readonly Volume Kiloliter = new("kiloliter", "kL", Hectoliter, 10.0, system: "SI");

   /// <summary>
   /// megaliter defined such that: kiloliter = ML × 1000.0.
   /// </summary>
   public static readonly Volume Megaliter = new("megaliter", "ML", Kiloliter, 1000.0, system: "SI");

   /// <summary>
   /// gigaliter defined such that: megaliter = GL × 1000.0.
   /// </summary>
   public static readonly Volume Gigaliter = new("gigaliter", "GL", Megaliter, 1000.0, system: "SI");

   /// <summary>
   /// teraliter defined such that: gigaliter = TL × 1000.0.
   /// </summary>
   public static readonly Volume Teraliter = new("teraliter", "TL", Gigaliter, 1000.0, system: "SI");

   /// <summary>
   /// petaliter defined such that: teraliter = PL × 1000.0.
   /// </summary>
   public static readonly Volume Petaliter = new("petaliter", "PL", Teraliter, 1000.0, system: "SI");

   /// <summary>
   /// exaliter defined such that: petaliter = EL × 1000.0.
   /// </summary>
   public static readonly Volume Exaliter = new("exaliter", "EL", Petaliter, 1000.0, system: "SI");

   /// <summary>
   /// zettaliter defined such that: exaliter = ZL × 1000.0.
   /// </summary>
   public static readonly Volume Zettaliter = new("zettaliter", "ZL", Exaliter, 1000.0, system: "SI");

   /// <summary>
   /// yottaliter defined such that: zettaliter = YL × 1000.0.
   /// </summary>
   public static readonly Volume Yottaliter = new("yottaliter", "YL", Zettaliter, 1000.0, system: "SI");

   /// <summary>
   /// ronnaliter defined such that: yottaliter = RL × 1000.0.
   /// </summary>
   public static readonly Volume Ronnaliter = new("ronnaliter", "RL", Yottaliter, 1000.0, system: "SI");

   /// <summary>
   /// quettaliter defined such that: ronnaliter = QL × 1000.0.
   /// </summary>
   public static readonly Volume Quettaliter = new("quettaliter", "QL", Ronnaliter, 1000.0, system: "SI");
}