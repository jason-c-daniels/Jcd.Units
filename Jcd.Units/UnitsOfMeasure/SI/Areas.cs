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
   /// A(n) square decimeter. Defined as: (1.0/10.0)*(1.0/10.0) × square meter.
   /// </summary>
   public static readonly Area SquareDecimeter = new (
                                                      "square decimeter"
                                                    , "dm²"
                                                    , SquareMeter
                                                    , 1.0 / 10.0 * (1.0 / 10.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square centimeter. Defined as: (1.0/10.0)*(1.0/10.0) × square decimeter.
   /// </summary>
   public static readonly Area SquareCentimeter = new (
                                                       "square centimeter"
                                                     , "cm²"
                                                     , SquareDecimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square millimeter. Defined as: (1.0/10.0)*(1.0/10.0) × square centimeter.
   /// </summary>
   public static readonly Area SquareMillimeter = new (
                                                       "square millimeter"
                                                     , "mm²"
                                                     , SquareCentimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square micrometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square millimeter.
   /// </summary>
   public static readonly Area SquareMicrometer = new (
                                                       "square micrometer"
                                                     , "μm²"
                                                     , SquareMillimeter
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square nanometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square micrometer.
   /// </summary>
   public static readonly Area SquareNanometer = new (
                                                      "square nanometer"
                                                    , "nm²"
                                                    , SquareMicrometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square picometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square nanometer.
   /// </summary>
   public static readonly Area SquarePicometer = new (
                                                      "square picometer"
                                                    , "pm²"
                                                    , SquareNanometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square femtometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square picometer.
   /// </summary>
   public static readonly Area SquareFemtometer = new (
                                                       "square femtometer"
                                                     , "fm²"
                                                     , SquarePicometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square attometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square femtometer.
   /// </summary>
   public static readonly Area SquareAttometer = new (
                                                      "square attometer"
                                                    , "am²"
                                                    , SquareFemtometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                    , 0
                                                     );

   /// <summary>
   /// A(n) square zeptometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square attometer.
   /// </summary>
   public static readonly Area SquareZeptometer = new (
                                                       "square zeptometer"
                                                     , "zm²"
                                                     , SquareAttometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square yoctometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square zeptometer.
   /// </summary>
   public static readonly Area SquareYoctometer = new (
                                                       "square yoctometer"
                                                     , "ym²"
                                                     , SquareZeptometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square rontometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square yoctometer.
   /// </summary>
   public static readonly Area SquareRontometer = new (
                                                       "square rontometer"
                                                     , "rm²"
                                                     , SquareYoctometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quectometer. Defined as: (1.0/1000.0)*(1.0/1000.0) × square rontometer.
   /// </summary>
   public static readonly Area SquareQuectometer = new (
                                                        "square quectometer"
                                                      , "qm²"
                                                      , SquareRontometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      , 0
                                                       );

   /// <summary>
   /// A(n) square dekameter. Defined as: (10.0)*(10.0) × square meter.
   /// </summary>
   public static readonly Area SquareDekameter = new ("square dekameter", "dam²", SquareMeter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square hectometer. Defined as: (10.0)*(10.0) × square dekameter.
   /// </summary>
   public static readonly Area SquareHectometer = new ("square hectometer", "hm²", SquareDekameter, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square kilometer. Defined as: (10.0)*(10.0) × square hectometer.
   /// </summary>
   public static readonly Area SquareKilometer = new ("square kilometer", "km²", SquareHectometer, 10.0 * 10.0, 0);

   /// <summary>
   /// A(n) square megameter. Defined as: (1000.0)*(1000.0) × square kilometer.
   /// </summary>
   public static readonly Area SquareMegameter = new ("square megameter", "Mm²", SquareKilometer, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square gigameter. Defined as: (1000.0)*(1000.0) × square megameter.
   /// </summary>
   public static readonly Area SquareGigameter = new ("square gigameter", "Gm²", SquareMegameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square terameter. Defined as: (1000.0)*(1000.0) × square gigameter.
   /// </summary>
   public static readonly Area SquareTerameter = new ("square terameter", "Tm²", SquareGigameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square petameter. Defined as: (1000.0)*(1000.0) × square terameter.
   /// </summary>
   public static readonly Area SquarePetameter = new ("square petameter", "Pm²", SquareTerameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square exameter. Defined as: (1000.0)*(1000.0) × square petameter.
   /// </summary>
   public static readonly Area SquareExameter = new ("square exameter", "Em²", SquarePetameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square zettameter. Defined as: (1000.0)*(1000.0) × square exameter.
   /// </summary>
   public static readonly Area SquareZettameter = new ("square zettameter", "Zm²", SquareExameter, 1000.0 * 1000.0, 0);

   /// <summary>
   /// A(n) square yottameter. Defined as: (1000.0)*(1000.0) × square zettameter.
   /// </summary>
   public static readonly Area SquareYottameter = new (
                                                       "square yottameter"
                                                     , "Ym²"
                                                     , SquareZettameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square ronnameter. Defined as: (1000.0)*(1000.0) × square yottameter.
   /// </summary>
   public static readonly Area SquareRonnameter = new (
                                                       "square ronnameter"
                                                     , "Rm²"
                                                     , SquareYottameter
                                                     , 1000.0 * 1000.0
                                                     , 0
                                                      );

   /// <summary>
   /// A(n) square quettameter. Defined as: (1000.0)*(1000.0) × square ronnameter.
   /// </summary>
   public static readonly Area SquareQuettameter = new (
                                                        "square quettameter"
                                                      , "Qm²"
                                                      , SquareRonnameter
                                                      , 1000.0 * 1000.0
                                                      , 0
                                                       );
}
