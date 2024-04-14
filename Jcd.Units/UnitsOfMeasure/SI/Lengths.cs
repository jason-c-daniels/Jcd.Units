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
/// International System of Units for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// meter, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Length Meter = new("meter", "m", system: "SI");

   /// <summary>
   /// decimeter defined such that: meter = dm × 1.0/10.0.
   /// </summary>
   public static readonly Length Decimeter = new("decimeter", "dm", Meter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centimeter defined such that: decimeter = cm × 1.0/10.0.
   /// </summary>
   public static readonly Length Centimeter = new("centimeter", "cm", Decimeter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millimeter defined such that: centimeter = mm × 1.0/10.0.
   /// </summary>
   public static readonly Length Millimeter = new("millimeter", "mm", Centimeter, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// micrometer defined such that: millimeter = μm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Micrometer = new("micrometer", "μm", Millimeter, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanometer defined such that: micrometer = nm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Nanometer = new("nanometer", "nm", Micrometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picometer defined such that: nanometer = pm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Picometer = new("picometer", "pm", Nanometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtometer defined such that: picometer = fm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Femtometer = new("femtometer", "fm", Picometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attometer defined such that: femtometer = am × 1.0/1000.0.
   /// </summary>
   public static readonly Length Attometer = new("attometer", "am", Femtometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptometer defined such that: attometer = zm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Zeptometer = new("zeptometer", "zm", Attometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctometer defined such that: zeptometer = ym × 1.0/1000.0.
   /// </summary>
   public static readonly Length Yoctometer = new("yoctometer", "ym", Zeptometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontometer defined such that: yoctometer = rm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Rontometer = new("rontometer", "rm", Yoctometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectometer defined such that: rontometer = qm × 1.0/1000.0.
   /// </summary>
   public static readonly Length Quectometer = new("quectometer", "qm", Rontometer, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekameter defined such that: meter = dam × 10.0.
   /// </summary>
   public static readonly Length Dekameter = new("dekameter", "dam", Meter, 10.0, system: "SI");

   /// <summary>
   /// hectometer defined such that: dekameter = hm × 10.0.
   /// </summary>
   public static readonly Length Hectometer = new("hectometer", "hm", Dekameter, 10.0, system: "SI");

   /// <summary>
   /// kilometer defined such that: hectometer = km × 10.0.
   /// </summary>
   public static readonly Length Kilometer = new("kilometer", "km", Hectometer, 10.0, system: "SI");

   /// <summary>
   /// megameter defined such that: kilometer = Mm × 1000.0.
   /// </summary>
   public static readonly Length Megameter = new("megameter", "Mm", Kilometer, 1000.0, system: "SI");

   /// <summary>
   /// gigameter defined such that: megameter = Gm × 1000.0.
   /// </summary>
   public static readonly Length Gigameter = new("gigameter", "Gm", Megameter, 1000.0, system: "SI");

   /// <summary>
   /// terameter defined such that: gigameter = Tm × 1000.0.
   /// </summary>
   public static readonly Length Terameter = new("terameter", "Tm", Gigameter, 1000.0, system: "SI");

   /// <summary>
   /// petameter defined such that: terameter = Pm × 1000.0.
   /// </summary>
   public static readonly Length Petameter = new("petameter", "Pm", Terameter, 1000.0, system: "SI");

   /// <summary>
   /// exameter defined such that: petameter = Em × 1000.0.
   /// </summary>
   public static readonly Length Exameter = new("exameter", "Em", Petameter, 1000.0, system: "SI");

   /// <summary>
   /// zettameter defined such that: exameter = Zm × 1000.0.
   /// </summary>
   public static readonly Length Zettameter = new("zettameter", "Zm", Exameter, 1000.0, system: "SI");

   /// <summary>
   /// yottameter defined such that: zettameter = Ym × 1000.0.
   /// </summary>
   public static readonly Length Yottameter = new("yottameter", "Ym", Zettameter, 1000.0, system: "SI");

   /// <summary>
   /// ronnameter defined such that: yottameter = Rm × 1000.0.
   /// </summary>
   public static readonly Length Ronnameter = new("ronnameter", "Rm", Yottameter, 1000.0, system: "SI");

   /// <summary>
   /// quettameter defined such that: ronnameter = Qm × 1000.0.
   /// </summary>
   public static readonly Length Quettameter = new("quettameter", "Qm", Ronnameter, 1000.0, system: "SI");
}