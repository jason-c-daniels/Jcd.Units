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
/// International System of Units for measuring Area.
/// </summary>
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// A(n) square meter.
   /// </summary>
   public static readonly Area SquareMeter = new ("square meter", "m^2");

   /// <summary>
   /// A(n) square decimeter. Defined in terms of a(n) square meter.
   /// </summary>
   public static readonly Area SquareDecimeter = new (
                                                      "square decimeter"
                                                    , "dm^2"
                                                    , SquareMeter
                                                    , 1.0 / 10.0 * (1.0 / 10.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square centimeter. Defined in terms of a(n) square decimeter.
   /// </summary>
   public static readonly Area SquareCentimeter = new (
                                                       "square centimeter"
                                                     , "cm^2"
                                                     , SquareDecimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square millimeter. Defined in terms of a(n) square centimeter.
   /// </summary>
   public static readonly Area SquareMillimeter = new (
                                                       "square millimeter"
                                                     , "mm^2"
                                                     , SquareCentimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square micrometer. Defined in terms of a(n) square millimeter.
   /// </summary>
   public static readonly Area SquareMicrometer = new (
                                                       "square micrometer"
                                                     , "μm^2"
                                                     , SquareMillimeter
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square nanometer. Defined in terms of a(n) square micrometer.
   /// </summary>
   public static readonly Area SquareNanometer = new (
                                                      "square nanometer"
                                                    , "nm^2"
                                                    , SquareMicrometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square picometer. Defined in terms of a(n) square nanometer.
   /// </summary>
   public static readonly Area SquarePicometer = new (
                                                      "square picometer"
                                                    , "pm^2"
                                                    , SquareNanometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square femtometer. Defined in terms of a(n) square picometer.
   /// </summary>
   public static readonly Area SquareFemtometer = new (
                                                       "square femtometer"
                                                     , "fm^2"
                                                     , SquarePicometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square attometer. Defined in terms of a(n) square femtometer.
   /// </summary>
   public static readonly Area SquareAttometer = new (
                                                      "square attometer"
                                                    , "am^2"
                                                    , SquareFemtometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square zeptometer. Defined in terms of a(n) square attometer.
   /// </summary>
   public static readonly Area SquareZeptometer = new (
                                                       "square zeptometer"
                                                     , "zm^2"
                                                     , SquareAttometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square yoctometer. Defined in terms of a(n) square zeptometer.
   /// </summary>
   public static readonly Area SquareYoctometer = new (
                                                       "square yoctometer"
                                                     , "ym^2"
                                                     , SquareZeptometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square rontometer. Defined in terms of a(n) square yoctometer.
   /// </summary>
   public static readonly Area SquareRontometer = new (
                                                       "square rontometer"
                                                     , "rm^2"
                                                     , SquareYoctometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quectometer. Defined in terms of a(n) square rontometer.
   /// </summary>
   public static readonly Area SquareQuectometer = new (
                                                        "square quectometer"
                                                      , "qm^2"
                                                      , SquareRontometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square dekameter. Defined in terms of a(n) square meter.
   /// </summary>
   public static readonly Area SquareDekameter = new ("square dekameter", "dam^2", SquareMeter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square hectometer. Defined in terms of a(n) square dekameter.
   /// </summary>
   public static readonly Area SquareHectometer = new ("square hectometer", "hm^2", SquareDekameter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square kilometer. Defined in terms of a(n) square hectometer.
   /// </summary>
   public static readonly Area SquareKilometer = new ("square kilometer", "km^2", SquareHectometer, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square megameter. Defined in terms of a(n) square kilometer.
   /// </summary>
   public static readonly Area SquareMegameter = new ("square megameter", "Mm^2", SquareKilometer, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square gigameter. Defined in terms of a(n) square megameter.
   /// </summary>
   public static readonly Area SquareGigameter = new ("square gigameter", "Gm^2", SquareMegameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square terameter. Defined in terms of a(n) square gigameter.
   /// </summary>
   public static readonly Area SquareTerameter = new ("square terameter", "Tm^2", SquareGigameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square petameter. Defined in terms of a(n) square terameter.
   /// </summary>
   public static readonly Area SquarePetameter = new ("square petameter", "Pm^2", SquareTerameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square exameter. Defined in terms of a(n) square petameter.
   /// </summary>
   public static readonly Area SquareExameter = new ("square exameter", "Em^2", SquarePetameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square zettameter. Defined in terms of a(n) square exameter.
   /// </summary>
   public static readonly Area SquareZettameter = new ("square zettameter", "Zm^2", SquareExameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square yottameter. Defined in terms of a(n) square zettameter.
   /// </summary>
   public static readonly Area SquareYottameter = new (
                                                       "square yottameter"
                                                     , "Ym^2"
                                                     , SquareZettameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square ronnameter. Defined in terms of a(n) square yottameter.
   /// </summary>
   public static readonly Area SquareRonnameter = new (
                                                       "square ronnameter"
                                                     , "Rm^2"
                                                     , SquareYottameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quettameter. Defined in terms of a(n) square ronnameter.
   /// </summary>
   public static readonly Area SquareQuettameter = new (
                                                        "square quettameter"
                                                      , "Qm^2"
                                                      , SquareRonnameter
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );
}
