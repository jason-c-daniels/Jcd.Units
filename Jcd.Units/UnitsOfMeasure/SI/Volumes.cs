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
public class Volumes : Enumeration<Volumes, Volume>
{
   /// <summary>
   /// A(n) cubic meter.
   /// </summary>
   public static readonly Volume CubicMeter = new ("cubic meter", "m^3");

   /// <summary>
   /// A(n) liter. Defined in terms of a(n) cubic decimeter.
   /// </summary>
   public static readonly Volume Liter = new ("liter", "L", CubicDecimeter, 1.0, 0);

   /// <summary>
   /// A(n) cubic decimeter. Defined in terms of a(n) cubic meter.
   /// </summary>
   public static readonly Volume CubicDecimeter = new (
                                                       "cubic decimeter"
                                                     , "dm^3"
                                                     , CubicMeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic centimeter. Defined in terms of a(n) cubic decimeter.
   /// </summary>
   public static readonly Volume CubicCentimeter = new (
                                                        "cubic centimeter"
                                                      , "cm^3"
                                                      , CubicDecimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic millimeter. Defined in terms of a(n) cubic centimeter.
   /// </summary>
   public static readonly Volume CubicMillimeter = new (
                                                        "cubic millimeter"
                                                      , "mm^3"
                                                      , CubicCentimeter
                                                      , 1.0 / 10.0 * (1.0 / 10.0) * (1.0 / 10.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic micrometer. Defined in terms of a(n) cubic millimeter.
   /// </summary>
   public static readonly Volume CubicMicrometer = new (
                                                        "cubic micrometer"
                                                      , "μm^3"
                                                      , CubicMillimeter
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic nanometer. Defined in terms of a(n) cubic micrometer.
   /// </summary>
   public static readonly Volume CubicNanometer = new (
                                                       "cubic nanometer"
                                                     , "nm^3"
                                                     , CubicMicrometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic picometer. Defined in terms of a(n) cubic nanometer.
   /// </summary>
   public static readonly Volume CubicPicometer = new (
                                                       "cubic picometer"
                                                     , "pm^3"
                                                     , CubicNanometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic femtometer. Defined in terms of a(n) cubic picometer.
   /// </summary>
   public static readonly Volume CubicFemtometer = new (
                                                        "cubic femtometer"
                                                      , "fm^3"
                                                      , CubicPicometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic attometer. Defined in terms of a(n) cubic femtometer.
   /// </summary>
   public static readonly Volume CubicAttometer = new (
                                                       "cubic attometer"
                                                     , "am^3"
                                                     , CubicFemtometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic zeptometer. Defined in terms of a(n) cubic attometer.
   /// </summary>
   public static readonly Volume CubicZeptometer = new (
                                                        "cubic zeptometer"
                                                      , "zm^3"
                                                      , CubicAttometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic yoctometer. Defined in terms of a(n) cubic zeptometer.
   /// </summary>
   public static readonly Volume CubicYoctometer = new (
                                                        "cubic yoctometer"
                                                      , "ym^3"
                                                      , CubicZeptometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic rontometer. Defined in terms of a(n) cubic yoctometer.
   /// </summary>
   public static readonly Volume CubicRontometer = new (
                                                        "cubic rontometer"
                                                      , "rm^3"
                                                      , CubicYoctometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic quectometer. Defined in terms of a(n) cubic rontometer.
   /// </summary>
   public static readonly Volume CubicQuectometer = new (
                                                         "cubic quectometer"
                                                       , "qm^3"
                                                       , CubicRontometer
                                                       , 1.0 / 1000.0 * (1.0 / 1000.0) * (1.0 / 1000.0)
                                                       , 0
                                                        );

   /// <summary>
   /// A(n) cubic dekameter. Defined in terms of a(n) cubic meter.
   /// </summary>
   public static readonly Volume CubicDekameter = new ("cubic dekameter", "dam^3", CubicMeter, 10.0 * 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) cubic hectometer. Defined in terms of a(n) cubic dekameter.
   /// </summary>
   public static readonly Volume CubicHectometer = new (
                                                        "cubic hectometer"
                                                      , "hm^3"
                                                      , CubicDekameter
                                                      , 10.0 * 10.0 * 10.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic kilometer. Defined in terms of a(n) cubic hectometer.
   /// </summary>
   public static readonly Volume CubicKilometer = new (
                                                       "cubic kilometer"
                                                     , "km^3"
                                                     , CubicHectometer
                                                     , 10.0 * 10.0 * 10.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic megameter. Defined in terms of a(n) cubic kilometer.
   /// </summary>
   public static readonly Volume CubicMegameter = new (
                                                       "cubic megameter"
                                                     , "Mm^3"
                                                     , CubicKilometer
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic gigameter. Defined in terms of a(n) cubic megameter.
   /// </summary>
   public static readonly Volume CubicGigameter = new (
                                                       "cubic gigameter"
                                                     , "Gm^3"
                                                     , CubicMegameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic terameter. Defined in terms of a(n) cubic gigameter.
   /// </summary>
   public static readonly Volume CubicTerameter = new (
                                                       "cubic terameter"
                                                     , "Tm^3"
                                                     , CubicGigameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic petameter. Defined in terms of a(n) cubic terameter.
   /// </summary>
   public static readonly Volume CubicPetameter = new (
                                                       "cubic petameter"
                                                     , "Pm^3"
                                                     , CubicTerameter
                                                     , 1000.0 * 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) cubic exameter. Defined in terms of a(n) cubic petameter.
   /// </summary>
   public static readonly Volume CubicExameter = new (
                                                      "cubic exameter"
                                                    , "Em^3"
                                                    , CubicPetameter
                                                    , 1000.0 * 1000.0 * 1000.0
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) cubic zettameter. Defined in terms of a(n) cubic exameter.
   /// </summary>
   public static readonly Volume CubicZettameter = new (
                                                        "cubic zettameter"
                                                      , "Zm^3"
                                                      , CubicExameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic yottameter. Defined in terms of a(n) cubic zettameter.
   /// </summary>
   public static readonly Volume CubicYottameter = new (
                                                        "cubic yottameter"
                                                      , "Ym^3"
                                                      , CubicZettameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic ronnameter. Defined in terms of a(n) cubic yottameter.
   /// </summary>
   public static readonly Volume CubicRonnameter = new (
                                                        "cubic ronnameter"
                                                      , "Rm^3"
                                                      , CubicYottameter
                                                      , 1000.0 * 1000.0 * 1000.0
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) cubic quettameter. Defined in terms of a(n) cubic ronnameter.
   /// </summary>
   public static readonly Volume CubicQuettameter = new (
                                                         "cubic quettameter"
                                                       , "Qm^3"
                                                       , CubicRonnameter
                                                       , 1000.0 * 1000.0 * 1000.0
                                                       , 0
                                                        );
}
