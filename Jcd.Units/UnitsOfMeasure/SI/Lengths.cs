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
   public static readonly Length Meter = new ("meter", "m");

   /// <summary>
   /// decimeter, defined as: meter × 1.0/10.0
   /// </summary>
   public static readonly Length Decimeter = new ("decimeter", "dm", Meter, 1.0 / 10.0);

   /// <summary>
   /// centimeter, defined as: decimeter × 1.0/10.0
   /// </summary>
   public static readonly Length Centimeter = new ("centimeter", "cm", Decimeter, 1.0 / 10.0);

   /// <summary>
   /// millimeter, defined as: centimeter × 1.0/10.0
   /// </summary>
   public static readonly Length Millimeter = new ("millimeter", "mm", Centimeter, 1.0 / 10.0);

   /// <summary>
   /// micrometer, defined as: millimeter × 1.0/1000.0
   /// </summary>
   public static readonly Length Micrometer = new ("micrometer", "μm", Millimeter, 1.0 / 1000.0);

   /// <summary>
   /// nanometer, defined as: micrometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Nanometer = new ("nanometer", "nm", Micrometer, 1.0 / 1000.0);

   /// <summary>
   /// picometer, defined as: nanometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Picometer = new ("picometer", "pm", Nanometer, 1.0 / 1000.0);

   /// <summary>
   /// femtometer, defined as: picometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Femtometer = new ("femtometer", "fm", Picometer, 1.0 / 1000.0);

   /// <summary>
   /// attometer, defined as: femtometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Attometer = new ("attometer", "am", Femtometer, 1.0 / 1000.0);

   /// <summary>
   /// zeptometer, defined as: attometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Zeptometer = new ("zeptometer", "zm", Attometer, 1.0 / 1000.0);

   /// <summary>
   /// yoctometer, defined as: zeptometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Yoctometer = new ("yoctometer", "ym", Zeptometer, 1.0 / 1000.0);

   /// <summary>
   /// rontometer, defined as: yoctometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Rontometer = new ("rontometer", "rm", Yoctometer, 1.0 / 1000.0);

   /// <summary>
   /// quectometer, defined as: rontometer × 1.0/1000.0
   /// </summary>
   public static readonly Length Quectometer = new ("quectometer", "qm", Rontometer, 1.0 / 1000.0);

   /// <summary>
   /// dekameter, defined as: meter × 10.0
   /// </summary>
   public static readonly Length Dekameter = new ("dekameter", "dam", Meter, 10.0);

   /// <summary>
   /// hectometer, defined as: dekameter × 10.0
   /// </summary>
   public static readonly Length Hectometer = new ("hectometer", "hm", Dekameter, 10.0);

   /// <summary>
   /// kilometer, defined as: hectometer × 10.0
   /// </summary>
   public static readonly Length Kilometer = new ("kilometer", "km", Hectometer, 10.0);

   /// <summary>
   /// megameter, defined as: kilometer × 1000.0
   /// </summary>
   public static readonly Length Megameter = new ("megameter", "Mm", Kilometer, 1000.0);

   /// <summary>
   /// gigameter, defined as: megameter × 1000.0
   /// </summary>
   public static readonly Length Gigameter = new ("gigameter", "Gm", Megameter, 1000.0);

   /// <summary>
   /// terameter, defined as: gigameter × 1000.0
   /// </summary>
   public static readonly Length Terameter = new ("terameter", "Tm", Gigameter, 1000.0);

   /// <summary>
   /// petameter, defined as: terameter × 1000.0
   /// </summary>
   public static readonly Length Petameter = new ("petameter", "Pm", Terameter, 1000.0);

   /// <summary>
   /// exameter, defined as: petameter × 1000.0
   /// </summary>
   public static readonly Length Exameter = new ("exameter", "Em", Petameter, 1000.0);

   /// <summary>
   /// zettameter, defined as: exameter × 1000.0
   /// </summary>
   public static readonly Length Zettameter = new ("zettameter", "Zm", Exameter, 1000.0);

   /// <summary>
   /// yottameter, defined as: zettameter × 1000.0
   /// </summary>
   public static readonly Length Yottameter = new ("yottameter", "Ym", Zettameter, 1000.0);

   /// <summary>
   /// ronnameter, defined as: yottameter × 1000.0
   /// </summary>
   public static readonly Length Ronnameter = new ("ronnameter", "Rm", Yottameter, 1000.0);

   /// <summary>
   /// quettameter, defined as: ronnameter × 1000.0
   /// </summary>
   public static readonly Length Quettameter = new ("quettameter", "Qm", Ronnameter, 1000.0);
}
