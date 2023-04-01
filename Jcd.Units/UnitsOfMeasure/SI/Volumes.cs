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
   public static readonly Volume CubicMeter = new ("cubic meter", "m³", system: "SI");

   /// <summary>
   /// cubic decimeter, defined as: cubic meter × (1.0/10.0)*(1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Volume CubicDecimeter = new (
                                                       "cubic decimeter"
                                                     , "dm³"
                                                     , CubicMeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic centimeter, defined as: cubic decimeter × (1.0/10.0)*(1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Volume CubicCentimeter = new (
                                                        "cubic centimeter"
                                                      , "cm³"
                                                      , CubicDecimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic millimeter, defined as: cubic centimeter × (1.0/10.0)*(1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Volume CubicMillimeter = new (
                                                        "cubic millimeter"
                                                      , "mm³"
                                                      , CubicCentimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic micrometer, defined as: cubic millimeter × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicMicrometer = new (
                                                        "cubic micrometer"
                                                      , "μm³"
                                                      , CubicMillimeter
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic nanometer, defined as: cubic micrometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicNanometer = new (
                                                       "cubic nanometer"
                                                     , "nm³"
                                                     , CubicMicrometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic picometer, defined as: cubic nanometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicPicometer = new (
                                                       "cubic picometer"
                                                     , "pm³"
                                                     , CubicNanometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic femtometer, defined as: cubic picometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicFemtometer = new (
                                                        "cubic femtometer"
                                                      , "fm³"
                                                      , CubicPicometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic attometer, defined as: cubic femtometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicAttometer = new (
                                                       "cubic attometer"
                                                     , "am³"
                                                     , CubicFemtometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic zeptometer, defined as: cubic attometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicZeptometer = new (
                                                        "cubic zeptometer"
                                                      , "zm³"
                                                      , CubicAttometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic yoctometer, defined as: cubic zeptometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicYoctometer = new (
                                                        "cubic yoctometer"
                                                      , "ym³"
                                                      , CubicZeptometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic rontometer, defined as: cubic yoctometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicRontometer = new (
                                                        "cubic rontometer"
                                                      , "rm³"
                                                      , CubicYoctometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic quectometer, defined as: cubic rontometer × (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Volume CubicQuectometer = new (
                                                         "cubic quectometer"
                                                       , "qm³"
                                                       , CubicRontometer
                                                       , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                       , system: "SI"
                                                        );

   /// <summary>
   /// cubic dekameter, defined as: cubic meter × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicDekameter = new (
                                                       "cubic dekameter"
                                                     , "dam³"
                                                     , CubicMeter
                                                     , 10.0 * 10.0 * 10.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic hectometer, defined as: cubic dekameter × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicHectometer = new (
                                                        "cubic hectometer"
                                                      , "hm³"
                                                      , CubicDekameter
                                                      , 10.0 * 10.0 * 10.0
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic kilometer, defined as: cubic hectometer × (10.0)*(10.0)*(10.0)
   /// </summary>
   public static readonly Volume CubicKilometer = new (
                                                       "cubic kilometer"
                                                     , "km³"
                                                     , CubicHectometer
                                                     , 10.0 * 10.0 * 10.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic megameter, defined as: cubic kilometer × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicMegameter = new (
                                                       "cubic megameter"
                                                     , "Mm³"
                                                     , CubicKilometer
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic gigameter, defined as: cubic megameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicGigameter = new (
                                                       "cubic gigameter"
                                                     , "Gm³"
                                                     , CubicMegameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic terameter, defined as: cubic gigameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicTerameter = new (
                                                       "cubic terameter"
                                                     , "Tm³"
                                                     , CubicGigameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic petameter, defined as: cubic terameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicPetameter = new (
                                                       "cubic petameter"
                                                     , "Pm³"
                                                     , CubicTerameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , system: "SI"
                                                      );

   /// <summary>
   /// cubic exameter, defined as: cubic petameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicExameter = new (
                                                      "cubic exameter"
                                                    , "Em³"
                                                    , CubicPetameter
                                                    , 1000.0 * 1000.0 * 1000.0
                                                    , system: "SI"
                                                     );

   /// <summary>
   /// cubic zettameter, defined as: cubic exameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicZettameter = new (
                                                        "cubic zettameter"
                                                      , "Zm³"
                                                      , CubicExameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic yottameter, defined as: cubic zettameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicYottameter = new (
                                                        "cubic yottameter"
                                                      , "Ym³"
                                                      , CubicZettameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic ronnameter, defined as: cubic yottameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicRonnameter = new (
                                                        "cubic ronnameter"
                                                      , "Rm³"
                                                      , CubicYottameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , system: "SI"
                                                       );

   /// <summary>
   /// cubic quettameter, defined as: cubic ronnameter × (1000.0)*(1000.0)*(1000.0)
   /// </summary>
   public static readonly Volume CubicQuettameter = new (
                                                         "cubic quettameter"
                                                       , "Qm³"
                                                       , CubicRonnameter
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , system: "SI"
                                                        );

   /// <summary>
   /// liter, a synonym for cubic decimeter
   /// </summary>
   public static readonly Volume Liter = new ("liter", "L", CubicDecimeter, system: "SI");

   /// <summary>
   /// deciliter, defined as: liter × 1.0/10.0
   /// </summary>
   public static readonly Volume Deciliter = new ("deciliter", "dL", Liter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiliter, defined as: deciliter × 1.0/10.0
   /// </summary>
   public static readonly Volume Centiliter = new ("centiliter", "cL", Deciliter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliliter, defined as: centiliter × 1.0/10.0
   /// </summary>
   public static readonly Volume Milliliter = new ("milliliter", "mL", Centiliter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microliter, defined as: milliliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Microliter = new ("microliter", "μL", Milliliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanoliter, defined as: microliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Nanoliter = new ("nanoliter", "nL", Microliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picoliter, defined as: nanoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Picoliter = new ("picoliter", "pL", Nanoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtoliter, defined as: picoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Femtoliter = new ("femtoliter", "fL", Picoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attoliter, defined as: femtoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Attoliter = new ("attoliter", "aL", Femtoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptoliter, defined as: attoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Zeptoliter = new ("zeptoliter", "zL", Attoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctoliter, defined as: zeptoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Yoctoliter = new ("yoctoliter", "yL", Zeptoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontoliter, defined as: yoctoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Rontoliter = new ("rontoliter", "rL", Yoctoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectoliter, defined as: rontoliter × 1.0/1000.0
   /// </summary>
   public static readonly Volume Quectoliter = new ("quectoliter", "qL", Rontoliter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekaliter, defined as: liter × 10.0
   /// </summary>
   public static readonly Volume Dekaliter = new ("dekaliter", "daL", Liter, 10.0, system: "SI");

   /// <summary>
   /// hectoliter, defined as: dekaliter × 10.0
   /// </summary>
   public static readonly Volume Hectoliter = new ("hectoliter", "hL", Dekaliter, 10.0, system: "SI");

   /// <summary>
   /// kiloliter, defined as: hectoliter × 10.0
   /// </summary>
   public static readonly Volume Kiloliter = new ("kiloliter", "kL", Hectoliter, 10.0, system: "SI");

   /// <summary>
   /// megaliter, defined as: kiloliter × 1000.0
   /// </summary>
   public static readonly Volume Megaliter = new ("megaliter", "ML", Kiloliter, 1000.0, system: "SI");

   /// <summary>
   /// gigaliter, defined as: megaliter × 1000.0
   /// </summary>
   public static readonly Volume Gigaliter = new ("gigaliter", "GL", Megaliter, 1000.0, system: "SI");

   /// <summary>
   /// teraliter, defined as: gigaliter × 1000.0
   /// </summary>
   public static readonly Volume Teraliter = new ("teraliter", "TL", Gigaliter, 1000.0, system: "SI");

   /// <summary>
   /// petaliter, defined as: teraliter × 1000.0
   /// </summary>
   public static readonly Volume Petaliter = new ("petaliter", "PL", Teraliter, 1000.0, system: "SI");

   /// <summary>
   /// exaliter, defined as: petaliter × 1000.0
   /// </summary>
   public static readonly Volume Exaliter = new ("exaliter", "EL", Petaliter, 1000.0, system: "SI");

   /// <summary>
   /// zettaliter, defined as: exaliter × 1000.0
   /// </summary>
   public static readonly Volume Zettaliter = new ("zettaliter", "ZL", Exaliter, 1000.0, system: "SI");

   /// <summary>
   /// yottaliter, defined as: zettaliter × 1000.0
   /// </summary>
   public static readonly Volume Yottaliter = new ("yottaliter", "YL", Zettaliter, 1000.0, system: "SI");

   /// <summary>
   /// ronnaliter, defined as: yottaliter × 1000.0
   /// </summary>
   public static readonly Volume Ronnaliter = new ("ronnaliter", "RL", Yottaliter, 1000.0, system: "SI");

   /// <summary>
   /// quettaliter, defined as: ronnaliter × 1000.0
   /// </summary>
   public static readonly Volume Quettaliter = new ("quettaliter", "QL", Ronnaliter, 1000.0, system: "SI");
}
