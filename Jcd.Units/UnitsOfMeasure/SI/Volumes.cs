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
   /// A(n) cubic meter.
   /// </summary>
   public static readonly Volume CubicMeter = new ("cubic meter", "m³");

   /// <summary>
   /// A(n) cubic decimeter. Defined as: (1.0/10.0)*(1.0/10.0)*(1.0/10.0) × cubic meter.
   /// </summary>
   public static readonly Volume CubicDecimeter = new (
                                                       "cubic decimeter"
                                                     , "dm³"
                                                     , CubicMeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic centimeter. Defined as: (1.0/10.0)*(1.0/10.0)*(1.0/10.0) × cubic decimeter.
   /// </summary>
   public static readonly Volume CubicCentimeter = new (
                                                        "cubic centimeter"
                                                      , "cm³"
                                                      , CubicDecimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic millimeter. Defined as: (1.0/10.0)*(1.0/10.0)*(1.0/10.0) × cubic centimeter.
   /// </summary>
   public static readonly Volume CubicMillimeter = new (
                                                        "cubic millimeter"
                                                      , "mm³"
                                                      , CubicCentimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic micrometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic millimeter.
   /// </summary>
   public static readonly Volume CubicMicrometer = new (
                                                        "cubic micrometer"
                                                      , "μm³"
                                                      , CubicMillimeter
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic nanometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic micrometer.
   /// </summary>
   public static readonly Volume CubicNanometer = new (
                                                       "cubic nanometer"
                                                     , "nm³"
                                                     , CubicMicrometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic picometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic nanometer.
   /// </summary>
   public static readonly Volume CubicPicometer = new (
                                                       "cubic picometer"
                                                     , "pm³"
                                                     , CubicNanometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic femtometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic picometer.
   /// </summary>
   public static readonly Volume CubicFemtometer = new (
                                                        "cubic femtometer"
                                                      , "fm³"
                                                      , CubicPicometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic attometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic femtometer.
   /// </summary>
   public static readonly Volume CubicAttometer = new (
                                                       "cubic attometer"
                                                     , "am³"
                                                     , CubicFemtometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic zeptometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic attometer.
   /// </summary>
   public static readonly Volume CubicZeptometer = new (
                                                        "cubic zeptometer"
                                                      , "zm³"
                                                      , CubicAttometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic yoctometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic zeptometer.
   /// </summary>
   public static readonly Volume CubicYoctometer = new (
                                                        "cubic yoctometer"
                                                      , "ym³"
                                                      , CubicZeptometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic rontometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic yoctometer.
   /// </summary>
   public static readonly Volume CubicRontometer = new (
                                                        "cubic rontometer"
                                                      , "rm³"
                                                      , CubicYoctometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic quectometer. Defined as: (1.0/1000.0)*(1.0/1000.0)*(1.0/1000.0) × cubic rontometer.
   /// </summary>
   public static readonly Volume CubicQuectometer = new (
                                                         "cubic quectometer"
                                                       , "qm³"
                                                       , CubicRontometer
                                                       , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic dekameter. Defined as: (10.0)*(10.0)*(10.0) × cubic meter.
   /// </summary>
   public static readonly Volume CubicDekameter = new ("cubic dekameter", "dam³", CubicMeter, 10.0 * 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) cubic hectometer. Defined as: (10.0)*(10.0)*(10.0) × cubic dekameter.
   /// </summary>
   public static readonly Volume CubicHectometer = new (
                                                        "cubic hectometer"
                                                      , "hm³"
                                                      , CubicDekameter
                                                      , 10.0 * 10.0 * 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic kilometer. Defined as: (10.0)*(10.0)*(10.0) × cubic hectometer.
   /// </summary>
   public static readonly Volume CubicKilometer = new (
                                                       "cubic kilometer"
                                                     , "km³"
                                                     , CubicHectometer
                                                     , 10.0 * 10.0 * 10.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic megameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic kilometer.
   /// </summary>
   public static readonly Volume CubicMegameter = new (
                                                       "cubic megameter"
                                                     , "Mm³"
                                                     , CubicKilometer
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic gigameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic megameter.
   /// </summary>
   public static readonly Volume CubicGigameter = new (
                                                       "cubic gigameter"
                                                     , "Gm³"
                                                     , CubicMegameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic terameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic gigameter.
   /// </summary>
   public static readonly Volume CubicTerameter = new (
                                                       "cubic terameter"
                                                     , "Tm³"
                                                     , CubicGigameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic petameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic terameter.
   /// </summary>
   public static readonly Volume CubicPetameter = new (
                                                       "cubic petameter"
                                                     , "Pm³"
                                                     , CubicTerameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic exameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic petameter.
   /// </summary>
   public static readonly Volume CubicExameter = new (
                                                      "cubic exameter"
                                                    , "Em³"
                                                    , CubicPetameter
                                                    , 1000.0 * 1000.0 * 1000.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) cubic zettameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic exameter.
   /// </summary>
   public static readonly Volume CubicZettameter = new (
                                                        "cubic zettameter"
                                                      , "Zm³"
                                                      , CubicExameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic yottameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic zettameter.
   /// </summary>
   public static readonly Volume CubicYottameter = new (
                                                        "cubic yottameter"
                                                      , "Ym³"
                                                      , CubicZettameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic ronnameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic yottameter.
   /// </summary>
   public static readonly Volume CubicRonnameter = new (
                                                        "cubic ronnameter"
                                                      , "Rm³"
                                                      , CubicYottameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic quettameter. Defined as: (1000.0)*(1000.0)*(1000.0) × cubic ronnameter.
   /// </summary>
   public static readonly Volume CubicQuettameter = new (
                                                         "cubic quettameter"
                                                       , "Qm³"
                                                       , CubicRonnameter
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) liter. Defined as: 1.0 × cubic decimeter.
   /// </summary>
   public static readonly Volume Liter = new ("liter", "L", CubicDecimeter, 1.0, 0);

   /// <summary>
   /// A(n) deciliter. Defined as: 1.0/10.0 × liter.
   /// </summary>
   public static readonly Volume Deciliter = new ("deciliter", "dL", Liter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centiliter. Defined as: 1.0/10.0 × deciliter.
   /// </summary>
   public static readonly Volume Centiliter = new ("centiliter", "cL", Deciliter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milliliter. Defined as: 1.0/10.0 × centiliter.
   /// </summary>
   public static readonly Volume Milliliter = new ("milliliter", "mL", Centiliter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microliter. Defined as: 1.0/1000.0 × milliliter.
   /// </summary>
   public static readonly Volume Microliter = new ("microliter", "μL", Milliliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanoliter. Defined as: 1.0/1000.0 × microliter.
   /// </summary>
   public static readonly Volume Nanoliter = new ("nanoliter", "nL", Microliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picoliter. Defined as: 1.0/1000.0 × nanoliter.
   /// </summary>
   public static readonly Volume Picoliter = new ("picoliter", "pL", Nanoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtoliter. Defined as: 1.0/1000.0 × picoliter.
   /// </summary>
   public static readonly Volume Femtoliter = new ("femtoliter", "fL", Picoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attoliter. Defined as: 1.0/1000.0 × femtoliter.
   /// </summary>
   public static readonly Volume Attoliter = new ("attoliter", "aL", Femtoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptoliter. Defined as: 1.0/1000.0 × attoliter.
   /// </summary>
   public static readonly Volume Zeptoliter = new ("zeptoliter", "zL", Attoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctoliter. Defined as: 1.0/1000.0 × zeptoliter.
   /// </summary>
   public static readonly Volume Yoctoliter = new ("yoctoliter", "yL", Zeptoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontoliter. Defined as: 1.0/1000.0 × yoctoliter.
   /// </summary>
   public static readonly Volume Rontoliter = new ("rontoliter", "rL", Yoctoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectoliter. Defined as: 1.0/1000.0 × rontoliter.
   /// </summary>
   public static readonly Volume Quectoliter = new ("quectoliter", "qL", Rontoliter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekaliter. Defined as: 10.0 × liter.
   /// </summary>
   public static readonly Volume Dekaliter = new ("dekaliter", "daL", Liter, 10.0, 0);

   /// <summary>
   /// A(n) hectoliter. Defined as: 10.0 × dekaliter.
   /// </summary>
   public static readonly Volume Hectoliter = new ("hectoliter", "hL", Dekaliter, 10.0, 0);

   /// <summary>
   /// A(n) kiloliter. Defined as: 10.0 × hectoliter.
   /// </summary>
   public static readonly Volume Kiloliter = new ("kiloliter", "kL", Hectoliter, 10.0, 0);

   /// <summary>
   /// A(n) megaliter. Defined as: 1000.0 × kiloliter.
   /// </summary>
   public static readonly Volume Megaliter = new ("megaliter", "ML", Kiloliter, 1000.0, 0);

   /// <summary>
   /// A(n) gigaliter. Defined as: 1000.0 × megaliter.
   /// </summary>
   public static readonly Volume Gigaliter = new ("gigaliter", "GL", Megaliter, 1000.0, 0);

   /// <summary>
   /// A(n) teraliter. Defined as: 1000.0 × gigaliter.
   /// </summary>
   public static readonly Volume Teraliter = new ("teraliter", "TL", Gigaliter, 1000.0, 0);

   /// <summary>
   /// A(n) petaliter. Defined as: 1000.0 × teraliter.
   /// </summary>
   public static readonly Volume Petaliter = new ("petaliter", "PL", Teraliter, 1000.0, 0);

   /// <summary>
   /// A(n) exaliter. Defined as: 1000.0 × petaliter.
   /// </summary>
   public static readonly Volume Exaliter = new ("exaliter", "EL", Petaliter, 1000.0, 0);

   /// <summary>
   /// A(n) zettaliter. Defined as: 1000.0 × exaliter.
   /// </summary>
   public static readonly Volume Zettaliter = new ("zettaliter", "ZL", Exaliter, 1000.0, 0);

   /// <summary>
   /// A(n) yottaliter. Defined as: 1000.0 × zettaliter.
   /// </summary>
   public static readonly Volume Yottaliter = new ("yottaliter", "YL", Zettaliter, 1000.0, 0);

   /// <summary>
   /// A(n) ronnaliter. Defined as: 1000.0 × yottaliter.
   /// </summary>
   public static readonly Volume Ronnaliter = new ("ronnaliter", "RL", Yottaliter, 1000.0, 0);

   /// <summary>
   /// A(n) quettaliter. Defined as: 1000.0 × ronnaliter.
   /// </summary>
   public static readonly Volume Quettaliter = new ("quettaliter", "QL", Ronnaliter, 1000.0, 0);
}
