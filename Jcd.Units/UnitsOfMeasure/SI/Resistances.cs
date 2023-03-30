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
   /// A(n) ohm.
   /// </summary>
   public static readonly Resistance Ohm = new ("ohm", "Ω");

   /// <summary>
   /// A(n) deciohm. Defined as: 1.0/10.0 × ohm.
   /// </summary>
   public static readonly Resistance Deciohm = new ("deciohm", "dΩ", Ohm, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centiohm. Defined as: 1.0/10.0 × deciohm.
   /// </summary>
   public static readonly Resistance Centiohm = new ("centiohm", "cΩ", Deciohm, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milliohm. Defined as: 1.0/10.0 × centiohm.
   /// </summary>
   public static readonly Resistance Milliohm = new ("milliohm", "mΩ", Centiohm, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microohm. Defined as: 1.0/1000.0 × milliohm.
   /// </summary>
   public static readonly Resistance Microohm = new ("microohm", "μΩ", Milliohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanoohm. Defined as: 1.0/1000.0 × microohm.
   /// </summary>
   public static readonly Resistance Nanoohm = new ("nanoohm", "nΩ", Microohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picoohm. Defined as: 1.0/1000.0 × nanoohm.
   /// </summary>
   public static readonly Resistance Picoohm = new ("picoohm", "pΩ", Nanoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtoohm. Defined as: 1.0/1000.0 × picoohm.
   /// </summary>
   public static readonly Resistance Femtoohm = new ("femtoohm", "fΩ", Picoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attoohm. Defined as: 1.0/1000.0 × femtoohm.
   /// </summary>
   public static readonly Resistance Attoohm = new ("attoohm", "aΩ", Femtoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptoohm. Defined as: 1.0/1000.0 × attoohm.
   /// </summary>
   public static readonly Resistance Zeptoohm = new ("zeptoohm", "zΩ", Attoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctoohm. Defined as: 1.0/1000.0 × zeptoohm.
   /// </summary>
   public static readonly Resistance Yoctoohm = new ("yoctoohm", "yΩ", Zeptoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontoohm. Defined as: 1.0/1000.0 × yoctoohm.
   /// </summary>
   public static readonly Resistance Rontoohm = new ("rontoohm", "rΩ", Yoctoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectoohm. Defined as: 1.0/1000.0 × rontoohm.
   /// </summary>
   public static readonly Resistance Quectoohm = new ("quectoohm", "qΩ", Rontoohm, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekaohm. Defined as: 10.0 × ohm.
   /// </summary>
   public static readonly Resistance Dekaohm = new ("dekaohm", "daΩ", Ohm, 10.0, 0);

   /// <summary>
   /// A(n) hectoohm. Defined as: 10.0 × dekaohm.
   /// </summary>
   public static readonly Resistance Hectoohm = new ("hectoohm", "hΩ", Dekaohm, 10.0, 0);

   /// <summary>
   /// A(n) kiloohm. Defined as: 10.0 × hectoohm.
   /// </summary>
   public static readonly Resistance Kiloohm = new ("kiloohm", "kΩ", Hectoohm, 10.0, 0);

   /// <summary>
   /// A(n) megaohm. Defined as: 1000.0 × kiloohm.
   /// </summary>
   public static readonly Resistance Megaohm = new ("megaohm", "MΩ", Kiloohm, 1000.0, 0);

   /// <summary>
   /// A(n) gigaohm. Defined as: 1000.0 × megaohm.
   /// </summary>
   public static readonly Resistance Gigaohm = new ("gigaohm", "GΩ", Megaohm, 1000.0, 0);

   /// <summary>
   /// A(n) teraohm. Defined as: 1000.0 × gigaohm.
   /// </summary>
   public static readonly Resistance Teraohm = new ("teraohm", "TΩ", Gigaohm, 1000.0, 0);

   /// <summary>
   /// A(n) petaohm. Defined as: 1000.0 × teraohm.
   /// </summary>
   public static readonly Resistance Petaohm = new ("petaohm", "PΩ", Teraohm, 1000.0, 0);

   /// <summary>
   /// A(n) exaohm. Defined as: 1000.0 × petaohm.
   /// </summary>
   public static readonly Resistance Exaohm = new ("exaohm", "EΩ", Petaohm, 1000.0, 0);

   /// <summary>
   /// A(n) zettaohm. Defined as: 1000.0 × exaohm.
   /// </summary>
   public static readonly Resistance Zettaohm = new ("zettaohm", "ZΩ", Exaohm, 1000.0, 0);

   /// <summary>
   /// A(n) yottaohm. Defined as: 1000.0 × zettaohm.
   /// </summary>
   public static readonly Resistance Yottaohm = new ("yottaohm", "YΩ", Zettaohm, 1000.0, 0);

   /// <summary>
   /// A(n) ronnaohm. Defined as: 1000.0 × yottaohm.
   /// </summary>
   public static readonly Resistance Ronnaohm = new ("ronnaohm", "RΩ", Yottaohm, 1000.0, 0);

   /// <summary>
   /// A(n) quettaohm. Defined as: 1000.0 × ronnaohm.
   /// </summary>
   public static readonly Resistance Quettaohm = new ("quettaohm", "QΩ", Ronnaohm, 1000.0, 0);
}
