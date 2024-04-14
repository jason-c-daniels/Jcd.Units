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
   public static readonly Area SquareMeter = new("square meter", "m²", system: "SI");
   
   /// <summary>
   /// square decimeter defined such that: square meter = dm² × (1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Area SquareDecimeter = new("square decimeter", "dm²", SquareMeter, 1.0 / 10.0 * (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// square centimeter defined such that: square decimeter = cm² × (1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Area SquareCentimeter = new("square centimeter", "cm²", SquareDecimeter, 1.0 / 10.0 * (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// square millimeter defined such that: square centimeter = mm² × (1.0/10.0)*(1.0/10.0).
   /// </summary>
   public static readonly Area SquareMillimeter = new("square millimeter", "mm²", SquareCentimeter, 1.0 / 10.0 * (1.0 / 10.0), system: "SI");
   
   /// <summary>
   /// square micrometer defined such that: square millimeter = μm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareMicrometer = new("square micrometer", "μm²", SquareMillimeter, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square nanometer defined such that: square micrometer = nm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareNanometer = new("square nanometer", "nm²", SquareMicrometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square picometer defined such that: square nanometer = pm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquarePicometer = new("square picometer", "pm²", SquareNanometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square femtometer defined such that: square picometer = fm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareFemtometer = new("square femtometer", "fm²", SquarePicometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square attometer defined such that: square femtometer = am² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareAttometer = new("square attometer", "am²", SquareFemtometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square zeptometer defined such that: square attometer = zm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareZeptometer = new("square zeptometer", "zm²", SquareAttometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square yoctometer defined such that: square zeptometer = ym² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareYoctometer = new("square yoctometer", "ym²", SquareZeptometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square rontometer defined such that: square yoctometer = rm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareRontometer = new("square rontometer", "rm²", SquareYoctometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square quectometer defined such that: square rontometer = qm² × (1.0/1000.0)*(1.0/1000.0).
   /// </summary>
   public static readonly Area SquareQuectometer = new("square quectometer", "qm²", SquareRontometer, 1.0 / 1000.0 * (1.0 / 1000.0), system: "SI");
   
   /// <summary>
   /// square dekameter defined such that: square meter = dam² × (10.0)*(10.0).
   /// </summary>
   public static readonly Area SquareDekameter = new("square dekameter", "dam²", SquareMeter, 10.0 * 10.0, system: "SI");
   
   /// <summary>
   /// square hectometer defined such that: square dekameter = hm² × (10.0)*(10.0).
   /// </summary>
   public static readonly Area SquareHectometer = new("square hectometer", "hm²", SquareDekameter, 10.0 * 10.0, system: "SI");
   
   /// <summary>
   /// square kilometer defined such that: square hectometer = km² × (10.0)*(10.0).
   /// </summary>
   public static readonly Area SquareKilometer = new("square kilometer", "km²", SquareHectometer, 10.0 * 10.0, system: "SI");
   
   /// <summary>
   /// square megameter defined such that: square kilometer = Mm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareMegameter = new("square megameter", "Mm²", SquareKilometer, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square gigameter defined such that: square megameter = Gm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareGigameter = new("square gigameter", "Gm²", SquareMegameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square terameter defined such that: square gigameter = Tm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareTerameter = new("square terameter", "Tm²", SquareGigameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square petameter defined such that: square terameter = Pm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquarePetameter = new("square petameter", "Pm²", SquareTerameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square exameter defined such that: square petameter = Em² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareExameter = new("square exameter", "Em²", SquarePetameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square zettameter defined such that: square exameter = Zm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareZettameter = new("square zettameter", "Zm²", SquareExameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square yottameter defined such that: square zettameter = Ym² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareYottameter = new("square yottameter", "Ym²", SquareZettameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square ronnameter defined such that: square yottameter = Rm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareRonnameter = new("square ronnameter", "Rm²", SquareYottameter, 1000.0 * 1000.0, system: "SI");
   
   /// <summary>
   /// square quettameter defined such that: square ronnameter = Qm² × (1000.0)*(1000.0).
   /// </summary>
   public static readonly Area SquareQuettameter = new("square quettameter", "Qm²", SquareRonnameter, 1000.0 * 1000.0, system: "SI");
}