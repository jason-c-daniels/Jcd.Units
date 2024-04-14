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
   public static readonly Frequency Hertz = new("hertz", "Hz", system: "SI");

   /// <summary>
   /// decihertz defined such that: hertz = dHz × 1.0/10.0.
   /// </summary>
   public static readonly Frequency Decihertz = new("decihertz", "dHz", Hertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centihertz defined such that: decihertz = cHz × 1.0/10.0.
   /// </summary>
   public static readonly Frequency Centihertz = new("centihertz", "cHz", Decihertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millihertz defined such that: centihertz = mHz × 1.0/10.0.
   /// </summary>
   public static readonly Frequency Millihertz = new("millihertz", "mHz", Centihertz, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microhertz defined such that: millihertz = μHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Microhertz = new("microhertz", "μHz", Millihertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanohertz defined such that: microhertz = nHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Nanohertz = new("nanohertz", "nHz", Microhertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picohertz defined such that: nanohertz = pHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Picohertz = new("picohertz", "pHz", Nanohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtohertz defined such that: picohertz = fHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Femtohertz = new("femtohertz", "fHz", Picohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attohertz defined such that: femtohertz = aHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Attohertz = new("attohertz", "aHz", Femtohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptohertz defined such that: attohertz = zHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Zeptohertz = new("zeptohertz", "zHz", Attohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctohertz defined such that: zeptohertz = yHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Yoctohertz = new("yoctohertz", "yHz", Zeptohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontohertz defined such that: yoctohertz = rHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Rontohertz = new("rontohertz", "rHz", Yoctohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectohertz defined such that: rontohertz = qHz × 1.0/1000.0.
   /// </summary>
   public static readonly Frequency Quectohertz = new("quectohertz", "qHz", Rontohertz, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekahertz defined such that: hertz = daHz × 10.0.
   /// </summary>
   public static readonly Frequency Dekahertz = new("dekahertz", "daHz", Hertz, 10.0, system: "SI");

   /// <summary>
   /// hectohertz defined such that: dekahertz = hHz × 10.0.
   /// </summary>
   public static readonly Frequency Hectohertz = new("hectohertz", "hHz", Dekahertz, 10.0, system: "SI");

   /// <summary>
   /// kilohertz defined such that: hectohertz = kHz × 10.0.
   /// </summary>
   public static readonly Frequency Kilohertz = new("kilohertz", "kHz", Hectohertz, 10.0, system: "SI");

   /// <summary>
   /// megahertz defined such that: kilohertz = MHz × 1000.0.
   /// </summary>
   public static readonly Frequency Megahertz = new("megahertz", "MHz", Kilohertz, 1000.0, system: "SI");

   /// <summary>
   /// gigahertz defined such that: megahertz = GHz × 1000.0.
   /// </summary>
   public static readonly Frequency Gigahertz = new("gigahertz", "GHz", Megahertz, 1000.0, system: "SI");

   /// <summary>
   /// terahertz defined such that: gigahertz = THz × 1000.0.
   /// </summary>
   public static readonly Frequency Terahertz = new("terahertz", "THz", Gigahertz, 1000.0, system: "SI");

   /// <summary>
   /// petahertz defined such that: terahertz = PHz × 1000.0.
   /// </summary>
   public static readonly Frequency Petahertz = new("petahertz", "PHz", Terahertz, 1000.0, system: "SI");

   /// <summary>
   /// exahertz defined such that: petahertz = EHz × 1000.0.
   /// </summary>
   public static readonly Frequency Exahertz = new("exahertz", "EHz", Petahertz, 1000.0, system: "SI");

   /// <summary>
   /// zettahertz defined such that: exahertz = ZHz × 1000.0.
   /// </summary>
   public static readonly Frequency Zettahertz = new("zettahertz", "ZHz", Exahertz, 1000.0, system: "SI");

   /// <summary>
   /// yottahertz defined such that: zettahertz = YHz × 1000.0.
   /// </summary>
   public static readonly Frequency Yottahertz = new("yottahertz", "YHz", Zettahertz, 1000.0, system: "SI");

   /// <summary>
   /// ronnahertz defined such that: yottahertz = RHz × 1000.0.
   /// </summary>
   public static readonly Frequency Ronnahertz = new("ronnahertz", "RHz", Yottahertz, 1000.0, system: "SI");

   /// <summary>
   /// quettahertz defined such that: ronnahertz = QHz × 1000.0.
   /// </summary>
   public static readonly Frequency Quettahertz = new("quettahertz", "QHz", Ronnahertz, 1000.0, system: "SI");
}