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
/// International System of Units for measuring Frequency.
/// </summary>
public class Frequencies : UnitOfMeasureEnumeration<Frequencies, Frequency>
{
   /// <summary>
   /// hertz, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Frequency Hertz = new ("hertz", "Hz", system: "SI");

   /// <summary>
   /// decihertz, defined as: hertz × 1.0/10.0
   /// </summary>
   public static readonly Frequency Decihertz = new ("decihertz", "dHz", Hertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centihertz, defined as: decihertz × 1.0/10.0
   /// </summary>
   public static readonly Frequency Centihertz = new ("centihertz", "cHz", Decihertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millihertz, defined as: centihertz × 1.0/10.0
   /// </summary>
   public static readonly Frequency Millihertz = new ("millihertz", "mHz", Centihertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microhertz, defined as: millihertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Microhertz = new ("microhertz", "μHz", Millihertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanohertz, defined as: microhertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Nanohertz = new ("nanohertz", "nHz", Microhertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picohertz, defined as: nanohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Picohertz = new ("picohertz", "pHz", Nanohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtohertz, defined as: picohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Femtohertz = new ("femtohertz", "fHz", Picohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attohertz, defined as: femtohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Attohertz = new ("attohertz", "aHz", Femtohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptohertz, defined as: attohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Zeptohertz = new ("zeptohertz", "zHz", Attohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctohertz, defined as: zeptohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Yoctohertz = new ("yoctohertz", "yHz", Zeptohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontohertz, defined as: yoctohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Rontohertz = new ("rontohertz", "rHz", Yoctohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectohertz, defined as: rontohertz × 1.0/1000.0
   /// </summary>
   public static readonly Frequency Quectohertz = new ("quectohertz", "qHz", Rontohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekahertz, defined as: hertz × 10.0
   /// </summary>
   public static readonly Frequency Dekahertz = new ("dekahertz", "daHz", Hertz, 10.0, system: "SI");

   /// <summary>
   /// hectohertz, defined as: dekahertz × 10.0
   /// </summary>
   public static readonly Frequency Hectohertz = new ("hectohertz", "hHz", Dekahertz, 10.0, system: "SI");

   /// <summary>
   /// kilohertz, defined as: hectohertz × 10.0
   /// </summary>
   public static readonly Frequency Kilohertz = new ("kilohertz", "kHz", Hectohertz, 10.0, system: "SI");

   /// <summary>
   /// megahertz, defined as: kilohertz × 1000.0
   /// </summary>
   public static readonly Frequency Megahertz = new ("megahertz", "MHz", Kilohertz, 1000.0, system: "SI");

   /// <summary>
   /// gigahertz, defined as: megahertz × 1000.0
   /// </summary>
   public static readonly Frequency Gigahertz = new ("gigahertz", "GHz", Megahertz, 1000.0, system: "SI");

   /// <summary>
   /// terahertz, defined as: gigahertz × 1000.0
   /// </summary>
   public static readonly Frequency Terahertz = new ("terahertz", "THz", Gigahertz, 1000.0, system: "SI");

   /// <summary>
   /// petahertz, defined as: terahertz × 1000.0
   /// </summary>
   public static readonly Frequency Petahertz = new ("petahertz", "PHz", Terahertz, 1000.0, system: "SI");

   /// <summary>
   /// exahertz, defined as: petahertz × 1000.0
   /// </summary>
   public static readonly Frequency Exahertz = new ("exahertz", "EHz", Petahertz, 1000.0, system: "SI");

   /// <summary>
   /// zettahertz, defined as: exahertz × 1000.0
   /// </summary>
   public static readonly Frequency Zettahertz = new ("zettahertz", "ZHz", Exahertz, 1000.0, system: "SI");

   /// <summary>
   /// yottahertz, defined as: zettahertz × 1000.0
   /// </summary>
   public static readonly Frequency Yottahertz = new ("yottahertz", "YHz", Zettahertz, 1000.0, system: "SI");

   /// <summary>
   /// ronnahertz, defined as: yottahertz × 1000.0
   /// </summary>
   public static readonly Frequency Ronnahertz = new ("ronnahertz", "RHz", Yottahertz, 1000.0, system: "SI");

   /// <summary>
   /// quettahertz, defined as: ronnahertz × 1000.0
   /// </summary>
   public static readonly Frequency Quettahertz = new ("quettahertz", "QHz", Ronnahertz, 1000.0, system: "SI");
}
