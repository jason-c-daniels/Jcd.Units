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
/// International System of Units for measuring Resistance.
/// </summary>
public class Resistances : UnitOfMeasureEnumeration<Resistances, Resistance>
{
   /// <summary>
   /// ohm, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Resistance Ohm = new ("ohm", "Ω", system: "SI");

   /// <summary>
   /// deciohm, defined as: ohm × 1.0/10.0
   /// </summary>
   public static readonly Resistance Deciohm = new ("deciohm", "dΩ", Ohm, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiohm, defined as: deciohm × 1.0/10.0
   /// </summary>
   public static readonly Resistance Centiohm = new ("centiohm", "cΩ", Deciohm, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliohm, defined as: centiohm × 1.0/10.0
   /// </summary>
   public static readonly Resistance Milliohm = new ("milliohm", "mΩ", Centiohm, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microohm, defined as: milliohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Microohm = new ("microohm", "μΩ", Milliohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanoohm, defined as: microohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Nanoohm = new ("nanoohm", "nΩ", Microohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picoohm, defined as: nanoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Picoohm = new ("picoohm", "pΩ", Nanoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtoohm, defined as: picoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Femtoohm = new ("femtoohm", "fΩ", Picoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attoohm, defined as: femtoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Attoohm = new ("attoohm", "aΩ", Femtoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptoohm, defined as: attoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Zeptoohm = new ("zeptoohm", "zΩ", Attoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctoohm, defined as: zeptoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Yoctoohm = new ("yoctoohm", "yΩ", Zeptoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontoohm, defined as: yoctoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Rontoohm = new ("rontoohm", "rΩ", Yoctoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectoohm, defined as: rontoohm × 1.0/1000.0
   /// </summary>
   public static readonly Resistance Quectoohm = new ("quectoohm", "qΩ", Rontoohm, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekaohm, defined as: ohm × 10.0
   /// </summary>
   public static readonly Resistance Dekaohm = new ("dekaohm", "daΩ", Ohm, 10.0, system: "SI");

   /// <summary>
   /// hectoohm, defined as: dekaohm × 10.0
   /// </summary>
   public static readonly Resistance Hectoohm = new ("hectoohm", "hΩ", Dekaohm, 10.0, system: "SI");

   /// <summary>
   /// kiloohm, defined as: hectoohm × 10.0
   /// </summary>
   public static readonly Resistance Kiloohm = new ("kiloohm", "kΩ", Hectoohm, 10.0, system: "SI");

   /// <summary>
   /// megaohm, defined as: kiloohm × 1000.0
   /// </summary>
   public static readonly Resistance Megaohm = new ("megaohm", "MΩ", Kiloohm, 1000.0, system: "SI");

   /// <summary>
   /// gigaohm, defined as: megaohm × 1000.0
   /// </summary>
   public static readonly Resistance Gigaohm = new ("gigaohm", "GΩ", Megaohm, 1000.0, system: "SI");

   /// <summary>
   /// teraohm, defined as: gigaohm × 1000.0
   /// </summary>
   public static readonly Resistance Teraohm = new ("teraohm", "TΩ", Gigaohm, 1000.0, system: "SI");

   /// <summary>
   /// petaohm, defined as: teraohm × 1000.0
   /// </summary>
   public static readonly Resistance Petaohm = new ("petaohm", "PΩ", Teraohm, 1000.0, system: "SI");

   /// <summary>
   /// exaohm, defined as: petaohm × 1000.0
   /// </summary>
   public static readonly Resistance Exaohm = new ("exaohm", "EΩ", Petaohm, 1000.0, system: "SI");

   /// <summary>
   /// zettaohm, defined as: exaohm × 1000.0
   /// </summary>
   public static readonly Resistance Zettaohm = new ("zettaohm", "ZΩ", Exaohm, 1000.0, system: "SI");

   /// <summary>
   /// yottaohm, defined as: zettaohm × 1000.0
   /// </summary>
   public static readonly Resistance Yottaohm = new ("yottaohm", "YΩ", Zettaohm, 1000.0, system: "SI");

   /// <summary>
   /// ronnaohm, defined as: yottaohm × 1000.0
   /// </summary>
   public static readonly Resistance Ronnaohm = new ("ronnaohm", "RΩ", Yottaohm, 1000.0, system: "SI");

   /// <summary>
   /// quettaohm, defined as: ronnaohm × 1000.0
   /// </summary>
   public static readonly Resistance Quettaohm = new ("quettaohm", "QΩ", Ronnaohm, 1000.0, system: "SI");
}
