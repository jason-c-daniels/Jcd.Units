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
   /// square meter, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Area SquareMeter = new ("square meter", "m²");

   /// <summary>
   /// square decimeter, defined as: square meter × (1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Area SquareDecimeter = new (
                                                      "square decimeter"
                                                    , "dm²"
                                                    , SquareMeter
                                                    , 1.0 / 10.0 * (1.0 / 10.0)
                                                     );

   /// <summary>
   /// square centimeter, defined as: square decimeter × (1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Area SquareCentimeter = new (
                                                       "square centimeter"
                                                     , "cm²"
                                                     , SquareDecimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                      );

   /// <summary>
   /// square millimeter, defined as: square centimeter × (1.0/10.0)*(1.0/10.0)
   /// </summary>
   public static readonly Area SquareMillimeter = new (
                                                       "square millimeter"
                                                     , "mm²"
                                                     , SquareCentimeter
                                                     , 1.0 / 10.0 * (1.0 / 10.0)
                                                      );

   /// <summary>
   /// square micrometer, defined as: square millimeter × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareMicrometer = new (
                                                       "square micrometer"
                                                     , "μm²"
                                                     , SquareMillimeter
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      );

   /// <summary>
   /// square nanometer, defined as: square micrometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareNanometer = new (
                                                      "square nanometer"
                                                    , "nm²"
                                                    , SquareMicrometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     );

   /// <summary>
   /// square picometer, defined as: square nanometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquarePicometer = new (
                                                      "square picometer"
                                                    , "pm²"
                                                    , SquareNanometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     );

   /// <summary>
   /// square femtometer, defined as: square picometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareFemtometer = new (
                                                       "square femtometer"
                                                     , "fm²"
                                                     , SquarePicometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      );

   /// <summary>
   /// square attometer, defined as: square femtometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareAttometer = new (
                                                      "square attometer"
                                                    , "am²"
                                                    , SquareFemtometer
                                                    , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                     );

   /// <summary>
   /// square zeptometer, defined as: square attometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareZeptometer = new (
                                                       "square zeptometer"
                                                     , "zm²"
                                                     , SquareAttometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      );

   /// <summary>
   /// square yoctometer, defined as: square zeptometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareYoctometer = new (
                                                       "square yoctometer"
                                                     , "ym²"
                                                     , SquareZeptometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      );

   /// <summary>
   /// square rontometer, defined as: square yoctometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareRontometer = new (
                                                       "square rontometer"
                                                     , "rm²"
                                                     , SquareYoctometer
                                                     , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                      );

   /// <summary>
   /// square quectometer, defined as: square rontometer × (1.0/1000.0)*(1.0/1000.0)
   /// </summary>
   public static readonly Area SquareQuectometer = new (
                                                        "square quectometer"
                                                      , "qm²"
                                                      , SquareRontometer
                                                      , 1.0 / 1000.0 * (1.0 / 1000.0)
                                                       );

   /// <summary>
   /// square dekameter, defined as: square meter × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareDekameter = new ("square dekameter", "dam²", SquareMeter, 10.0 * 10.0);

   /// <summary>
   /// square hectometer, defined as: square dekameter × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareHectometer = new ("square hectometer", "hm²", SquareDekameter, 10.0 * 10.0);

   /// <summary>
   /// square kilometer, defined as: square hectometer × (10.0)*(10.0)
   /// </summary>
   public static readonly Area SquareKilometer = new ("square kilometer", "km²", SquareHectometer, 10.0 * 10.0);

   /// <summary>
   /// square megameter, defined as: square kilometer × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareMegameter = new ("square megameter", "Mm²", SquareKilometer, 1000.0 * 1000.0);

   /// <summary>
   /// square gigameter, defined as: square megameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareGigameter = new ("square gigameter", "Gm²", SquareMegameter, 1000.0 * 1000.0);

   /// <summary>
   /// square terameter, defined as: square gigameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareTerameter = new ("square terameter", "Tm²", SquareGigameter, 1000.0 * 1000.0);

   /// <summary>
   /// square petameter, defined as: square terameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquarePetameter = new ("square petameter", "Pm²", SquareTerameter, 1000.0 * 1000.0);

   /// <summary>
   /// square exameter, defined as: square petameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareExameter = new ("square exameter", "Em²", SquarePetameter, 1000.0 * 1000.0);

   /// <summary>
   /// square zettameter, defined as: square exameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareZettameter = new ("square zettameter", "Zm²", SquareExameter, 1000.0 * 1000.0);

   /// <summary>
   /// square yottameter, defined as: square zettameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareYottameter = new ("square yottameter", "Ym²", SquareZettameter, 1000.0 * 1000.0);

   /// <summary>
   /// square ronnameter, defined as: square yottameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareRonnameter = new ("square ronnameter", "Rm²", SquareYottameter, 1000.0 * 1000.0);

   /// <summary>
   /// square quettameter, defined as: square ronnameter × (1000.0)*(1000.0)
   /// </summary>
   public static readonly Area SquareQuettameter = new ("square quettameter", "Qm²", SquareRonnameter, 1000.0 * 1000.0);
}
