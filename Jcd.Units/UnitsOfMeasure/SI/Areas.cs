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
   public static readonly Area SquareMeter = new ("square meter", "m²");

   /// <summary>
   /// A(n) square decimeter. Defined in terms of a(n) square meter.
   /// </summary>
   public static readonly Area SquareDecimeter = new (
                                                      "square decimeter"
                                                    , "dm²"
                                                    , SquareMeter
                                                    , 1.0 / 10.0 * (1.0 / 10.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square centimeter. Defined in terms of a(n) square decimeter.
   /// </summary>
   public static readonly Area SquareCentimeter = new (
                                                       "square centimeter"
                                                     , "cm²"
                                                     , SquareDecimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square millimeter. Defined in terms of a(n) square centimeter.
   /// </summary>
   public static readonly Area SquareMillimeter = new (
                                                       "square millimeter"
                                                     , "mm²"
                                                     , SquareCentimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square micrometer. Defined in terms of a(n) square millimeter.
   /// </summary>
   public static readonly Area SquareMicrometer = new (
                                                       "square micrometer"
                                                     , "μm²"
                                                     , SquareMillimeter
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square nanometer. Defined in terms of a(n) square micrometer.
   /// </summary>
   public static readonly Area SquareNanometer = new (
                                                      "square nanometer"
                                                    , "nm²"
                                                    , SquareMicrometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square picometer. Defined in terms of a(n) square nanometer.
   /// </summary>
   public static readonly Area SquarePicometer = new (
                                                      "square picometer"
                                                    , "pm²"
                                                    , SquareNanometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square femtometer. Defined in terms of a(n) square picometer.
   /// </summary>
   public static readonly Area SquareFemtometer = new (
                                                       "square femtometer"
                                                     , "fm²"
                                                     , SquarePicometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square attometer. Defined in terms of a(n) square femtometer.
   /// </summary>
   public static readonly Area SquareAttometer = new (
                                                      "square attometer"
                                                    , "am²"
                                                    , SquareFemtometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square zeptometer. Defined in terms of a(n) square attometer.
   /// </summary>
   public static readonly Area SquareZeptometer = new (
                                                       "square zeptometer"
                                                     , "zm²"
                                                     , SquareAttometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square yoctometer. Defined in terms of a(n) square zeptometer.
   /// </summary>
   public static readonly Area SquareYoctometer = new (
                                                       "square yoctometer"
                                                     , "ym²"
                                                     , SquareZeptometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square rontometer. Defined in terms of a(n) square yoctometer.
   /// </summary>
   public static readonly Area SquareRontometer = new (
                                                       "square rontometer"
                                                     , "rm²"
                                                     , SquareYoctometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quectometer. Defined in terms of a(n) square rontometer.
   /// </summary>
   public static readonly Area SquareQuectometer = new (
                                                        "square quectometer"
                                                      , "qm²"
                                                      , SquareRontometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square dekameter. Defined in terms of a(n) square meter.
   /// </summary>
   public static readonly Area SquareDekameter = new ("square dekameter", "dam²", SquareMeter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square hectometer. Defined in terms of a(n) square dekameter.
   /// </summary>
   public static readonly Area SquareHectometer = new ("square hectometer", "hm²", SquareDekameter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square kilometer. Defined in terms of a(n) square hectometer.
   /// </summary>
   public static readonly Area SquareKilometer = new ("square kilometer", "km²", SquareHectometer, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square megameter. Defined in terms of a(n) square kilometer.
   /// </summary>
   public static readonly Area SquareMegameter = new ("square megameter", "Mm²", SquareKilometer, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square gigameter. Defined in terms of a(n) square megameter.
   /// </summary>
   public static readonly Area SquareGigameter = new ("square gigameter", "Gm²", SquareMegameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square terameter. Defined in terms of a(n) square gigameter.
   /// </summary>
   public static readonly Area SquareTerameter = new ("square terameter", "Tm²", SquareGigameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square petameter. Defined in terms of a(n) square terameter.
   /// </summary>
   public static readonly Area SquarePetameter = new ("square petameter", "Pm²", SquareTerameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square exameter. Defined in terms of a(n) square petameter.
   /// </summary>
   public static readonly Area SquareExameter = new ("square exameter", "Em²", SquarePetameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square zettameter. Defined in terms of a(n) square exameter.
   /// </summary>
   public static readonly Area SquareZettameter = new ("square zettameter", "Zm²", SquareExameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square yottameter. Defined in terms of a(n) square zettameter.
   /// </summary>
   public static readonly Area SquareYottameter = new (
                                                       "square yottameter"
                                                     , "Ym²"
                                                     , SquareZettameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square ronnameter. Defined in terms of a(n) square yottameter.
   /// </summary>
   public static readonly Area SquareRonnameter = new (
                                                       "square ronnameter"
                                                     , "Rm²"
                                                     , SquareYottameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quettameter. Defined in terms of a(n) square ronnameter.
   /// </summary>
   public static readonly Area SquareQuettameter = new (
                                                        "square quettameter"
                                                      , "Qm²"
                                                      , SquareRonnameter
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );
}
