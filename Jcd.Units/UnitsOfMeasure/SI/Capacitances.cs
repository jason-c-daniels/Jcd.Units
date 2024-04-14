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
/// International System of Units for measuring Capacitance.
/// </summary>
public class Capacitances : UnitOfMeasureEnumeration<Capacitances, Capacitance>
{
   /// <summary>
   /// farad, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Capacitance Farad = new("farad", "F", system: "SI");
   
   /// <summary>
   /// decifarad defined such that: farad = dF × 1.0/10.0.
   /// </summary>
   public static readonly Capacitance Decifarad = new("decifarad", "dF", Farad, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centifarad defined such that: decifarad = cF × 1.0/10.0.
   /// </summary>
   public static readonly Capacitance Centifarad = new("centifarad", "cF", Decifarad, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millifarad defined such that: centifarad = mF × 1.0/10.0.
   /// </summary>
   public static readonly Capacitance Millifarad = new("millifarad", "mF", Centifarad, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microfarad defined such that: millifarad = μF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Microfarad = new("microfarad", "μF", Millifarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanofarad defined such that: microfarad = nF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Nanofarad = new("nanofarad", "nF", Microfarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picofarad defined such that: nanofarad = pF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Picofarad = new("picofarad", "pF", Nanofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtofarad defined such that: picofarad = fF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Femtofarad = new("femtofarad", "fF", Picofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attofarad defined such that: femtofarad = aF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Attofarad = new("attofarad", "aF", Femtofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptofarad defined such that: attofarad = zF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Zeptofarad = new("zeptofarad", "zF", Attofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctofarad defined such that: zeptofarad = yF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Yoctofarad = new("yoctofarad", "yF", Zeptofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontofarad defined such that: yoctofarad = rF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Rontofarad = new("rontofarad", "rF", Yoctofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectofarad defined such that: rontofarad = qF × 1.0/1000.0.
   /// </summary>
   public static readonly Capacitance Quectofarad = new("quectofarad", "qF", Rontofarad, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekafarad defined such that: farad = daF × 10.0.
   /// </summary>
   public static readonly Capacitance Dekafarad = new("dekafarad", "daF", Farad, 10.0, system: "SI");
   
   /// <summary>
   /// hectofarad defined such that: dekafarad = hF × 10.0.
   /// </summary>
   public static readonly Capacitance Hectofarad = new("hectofarad", "hF", Dekafarad, 10.0, system: "SI");
   
   /// <summary>
   /// kilofarad defined such that: hectofarad = kF × 10.0.
   /// </summary>
   public static readonly Capacitance Kilofarad = new("kilofarad", "kF", Hectofarad, 10.0, system: "SI");
   
   /// <summary>
   /// megafarad defined such that: kilofarad = MF × 1000.0.
   /// </summary>
   public static readonly Capacitance Megafarad = new("megafarad", "MF", Kilofarad, 1000.0, system: "SI");
   
   /// <summary>
   /// gigafarad defined such that: megafarad = GF × 1000.0.
   /// </summary>
   public static readonly Capacitance Gigafarad = new("gigafarad", "GF", Megafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// terafarad defined such that: gigafarad = TF × 1000.0.
   /// </summary>
   public static readonly Capacitance Terafarad = new("terafarad", "TF", Gigafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// petafarad defined such that: terafarad = PF × 1000.0.
   /// </summary>
   public static readonly Capacitance Petafarad = new("petafarad", "PF", Terafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// exafarad defined such that: petafarad = EF × 1000.0.
   /// </summary>
   public static readonly Capacitance Exafarad = new("exafarad", "EF", Petafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// zettafarad defined such that: exafarad = ZF × 1000.0.
   /// </summary>
   public static readonly Capacitance Zettafarad = new("zettafarad", "ZF", Exafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// yottafarad defined such that: zettafarad = YF × 1000.0.
   /// </summary>
   public static readonly Capacitance Yottafarad = new("yottafarad", "YF", Zettafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnafarad defined such that: yottafarad = RF × 1000.0.
   /// </summary>
   public static readonly Capacitance Ronnafarad = new("ronnafarad", "RF", Yottafarad, 1000.0, system: "SI");
   
   /// <summary>
   /// quettafarad defined such that: ronnafarad = QF × 1000.0.
   /// </summary>
   public static readonly Capacitance Quettafarad = new("quettafarad", "QF", Ronnafarad, 1000.0, system: "SI");
}