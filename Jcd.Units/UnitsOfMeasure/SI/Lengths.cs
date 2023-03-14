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
public class Lengths : Enumeration<Lengths, Length>
{
   /// <summary>
   /// A(n) meter.
   /// </summary>
   public static readonly Length Meter = new ("meter", "m");

   /// <summary>
   /// A(n) decimeter. Defined in terms of a(n) meter.
   /// </summary>
   public static readonly Length Decimeter = new ("decimeter", "dm", Meter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centimeter. Defined in terms of a(n) decimeter.
   /// </summary>
   public static readonly Length Centimeter = new ("centimeter", "cm", Decimeter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millimeter. Defined in terms of a(n) centimeter.
   /// </summary>
   public static readonly Length Millimeter = new ("millimeter", "mm", Centimeter, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) micrometer. Defined in terms of a(n) millimeter.
   /// </summary>
   public static readonly Length Micrometer = new ("micrometer", "μm", Millimeter, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanometer. Defined in terms of a(n) micrometer.
   /// </summary>
   public static readonly Length Nanometer = new ("nanometer", "nm", Micrometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picometer. Defined in terms of a(n) nanometer.
   /// </summary>
   public static readonly Length Picometer = new ("picometer", "pm", Nanometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtometer. Defined in terms of a(n) picometer.
   /// </summary>
   public static readonly Length Femtometer = new ("femtometer", "fm", Picometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attometer. Defined in terms of a(n) femtometer.
   /// </summary>
   public static readonly Length Attometer = new ("attometer", "am", Femtometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptometer. Defined in terms of a(n) attometer.
   /// </summary>
   public static readonly Length Zeptometer = new ("zeptometer", "zm", Attometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctometer. Defined in terms of a(n) zeptometer.
   /// </summary>
   public static readonly Length Yoctometer = new ("yoctometer", "ym", Zeptometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontometer. Defined in terms of a(n) yoctometer.
   /// </summary>
   public static readonly Length Rontometer = new ("rontometer", "rm", Yoctometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectometer. Defined in terms of a(n) rontometer.
   /// </summary>
   public static readonly Length Quectometer = new ("quectometer", "qm", Rontometer, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekameter. Defined in terms of a(n) meter.
   /// </summary>
   public static readonly Length Dekameter = new ("dekameter", "dam", Meter, 10.0, 0);

   /// <summary>
   /// A(n) hectometer. Defined in terms of a(n) dekameter.
   /// </summary>
   public static readonly Length Hectometer = new ("hectometer", "hm", Dekameter, 10.0, 0);

   /// <summary>
   /// A(n) kilometer. Defined in terms of a(n) hectometer.
   /// </summary>
   public static readonly Length Kilometer = new ("kilometer", "km", Hectometer, 10.0, 0);

   /// <summary>
   /// A(n) megameter. Defined in terms of a(n) kilometer.
   /// </summary>
   public static readonly Length Megameter = new ("megameter", "Mm", Kilometer, 1000.0, 0);

   /// <summary>
   /// A(n) gigameter. Defined in terms of a(n) megameter.
   /// </summary>
   public static readonly Length Gigameter = new ("gigameter", "Gm", Megameter, 1000.0, 0);

   /// <summary>
   /// A(n) terameter. Defined in terms of a(n) gigameter.
   /// </summary>
   public static readonly Length Terameter = new ("terameter", "Tm", Gigameter, 1000.0, 0);

   /// <summary>
   /// A(n) petameter. Defined in terms of a(n) terameter.
   /// </summary>
   public static readonly Length Petameter = new ("petameter", "Pm", Terameter, 1000.0, 0);

   /// <summary>
   /// A(n) exameter. Defined in terms of a(n) petameter.
   /// </summary>
   public static readonly Length Exameter = new ("exameter", "Em", Petameter, 1000.0, 0);

   /// <summary>
   /// A(n) zettameter. Defined in terms of a(n) exameter.
   /// </summary>
   public static readonly Length Zettameter = new ("zettameter", "Zm", Exameter, 1000.0, 0);

   /// <summary>
   /// A(n) yottameter. Defined in terms of a(n) zettameter.
   /// </summary>
   public static readonly Length Yottameter = new ("yottameter", "Ym", Zettameter, 1000.0, 0);

   /// <summary>
   /// A(n) ronnameter. Defined in terms of a(n) yottameter.
   /// </summary>
   public static readonly Length Ronnameter = new ("ronnameter", "Rm", Yottameter, 1000.0, 0);

   /// <summary>
   /// A(n) quettameter. Defined in terms of a(n) ronnameter.
   /// </summary>
   public static readonly Length Quettameter = new ("quettameter", "Qm", Ronnameter, 1000.0, 0);
}
