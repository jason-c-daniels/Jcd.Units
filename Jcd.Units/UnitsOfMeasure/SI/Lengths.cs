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
   /// A(n) meter.
   /// </summary>
   public static readonly Length Meter = new ("meter", "m");

   /// <summary>
   /// A(n) decimeter. Defined as: (1.0/10.0) × meter + (0).
   /// </summary>
   public static readonly Length Decimeter = new ("decimeter", "dm", Meter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centimeter. Defined as: (1.0/10.0) × decimeter + (0).
   /// </summary>
   public static readonly Length Centimeter = new ("centimeter", "cm", Decimeter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millimeter. Defined as: (1.0/10.0) × centimeter + (0).
   /// </summary>
   public static readonly Length Millimeter = new ("millimeter", "mm", Centimeter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) micrometer. Defined as: (1.0/1000.0) × millimeter + (0).
   /// </summary>
   public static readonly Length Micrometer = new ("micrometer", "μm", Millimeter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanometer. Defined as: (1.0/1000.0) × micrometer + (0).
   /// </summary>
   public static readonly Length Nanometer = new ("nanometer", "nm", Micrometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picometer. Defined as: (1.0/1000.0) × nanometer + (0).
   /// </summary>
   public static readonly Length Picometer = new ("picometer", "pm", Nanometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtometer. Defined as: (1.0/1000.0) × picometer + (0).
   /// </summary>
   public static readonly Length Femtometer = new ("femtometer", "fm", Picometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attometer. Defined as: (1.0/1000.0) × femtometer + (0).
   /// </summary>
   public static readonly Length Attometer = new ("attometer", "am", Femtometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptometer. Defined as: (1.0/1000.0) × attometer + (0).
   /// </summary>
   public static readonly Length Zeptometer = new ("zeptometer", "zm", Attometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctometer. Defined as: (1.0/1000.0) × zeptometer + (0).
   /// </summary>
   public static readonly Length Yoctometer = new ("yoctometer", "ym", Zeptometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontometer. Defined as: (1.0/1000.0) × yoctometer + (0).
   /// </summary>
   public static readonly Length Rontometer = new ("rontometer", "rm", Yoctometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectometer. Defined as: (1.0/1000.0) × rontometer + (0).
   /// </summary>
   public static readonly Length Quectometer = new ("quectometer", "qm", Rontometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekameter. Defined as: (10.0) × meter + (0).
   /// </summary>
   public static readonly Length Dekameter = new ("dekameter", "dam", Meter, 10.0, 0);

   /// <summary>
   /// A(n) hectometer. Defined as: (10.0) × dekameter + (0).
   /// </summary>
   public static readonly Length Hectometer = new ("hectometer", "hm", Dekameter, 10.0, 0);

   /// <summary>
   /// A(n) kilometer. Defined as: (10.0) × hectometer + (0).
   /// </summary>
   public static readonly Length Kilometer = new ("kilometer", "km", Hectometer, 10.0, 0);

   /// <summary>
   /// A(n) megameter. Defined as: (1000.0) × kilometer + (0).
   /// </summary>
   public static readonly Length Megameter = new ("megameter", "Mm", Kilometer, 1000.0, 0);

   /// <summary>
   /// A(n) gigameter. Defined as: (1000.0) × megameter + (0).
   /// </summary>
   public static readonly Length Gigameter = new ("gigameter", "Gm", Megameter, 1000.0, 0);

   /// <summary>
   /// A(n) terameter. Defined as: (1000.0) × gigameter + (0).
   /// </summary>
   public static readonly Length Terameter = new ("terameter", "Tm", Gigameter, 1000.0, 0);

   /// <summary>
   /// A(n) petameter. Defined as: (1000.0) × terameter + (0).
   /// </summary>
   public static readonly Length Petameter = new ("petameter", "Pm", Terameter, 1000.0, 0);

   /// <summary>
   /// A(n) exameter. Defined as: (1000.0) × petameter + (0).
   /// </summary>
   public static readonly Length Exameter = new ("exameter", "Em", Petameter, 1000.0, 0);

   /// <summary>
   /// A(n) zettameter. Defined as: (1000.0) × exameter + (0).
   /// </summary>
   public static readonly Length Zettameter = new ("zettameter", "Zm", Exameter, 1000.0, 0);

   /// <summary>
   /// A(n) yottameter. Defined as: (1000.0) × zettameter + (0).
   /// </summary>
   public static readonly Length Yottameter = new ("yottameter", "Ym", Zettameter, 1000.0, 0);

   /// <summary>
   /// A(n) ronnameter. Defined as: (1000.0) × yottameter + (0).
   /// </summary>
   public static readonly Length Ronnameter = new ("ronnameter", "Rm", Yottameter, 1000.0, 0);

   /// <summary>
   /// A(n) quettameter. Defined as: (1000.0) × ronnameter + (0).
   /// </summary>
   public static readonly Length Quettameter = new ("quettameter", "Qm", Ronnameter, 1000.0, 0);
}
