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
   /// A(n) farad.
   /// </summary>
   public static readonly Capacitance Farad = new ("farad", "F");

   /// <summary>
   /// A(n) decifarad. Defined as: (1.0/10.0) × farad + (0).
   /// </summary>
   public static readonly Capacitance Decifarad = new ("decifarad", "dF", Farad, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centifarad. Defined as: (1.0/10.0) × decifarad + (0).
   /// </summary>
   public static readonly Capacitance Centifarad = new ("centifarad", "cF", Decifarad, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millifarad. Defined as: (1.0/10.0) × centifarad + (0).
   /// </summary>
   public static readonly Capacitance Millifarad = new ("millifarad", "mF", Centifarad, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microfarad. Defined as: (1.0/1000.0) × millifarad + (0).
   /// </summary>
   public static readonly Capacitance Microfarad = new ("microfarad", "μF", Millifarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanofarad. Defined as: (1.0/1000.0) × microfarad + (0).
   /// </summary>
   public static readonly Capacitance Nanofarad = new ("nanofarad", "nF", Microfarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picofarad. Defined as: (1.0/1000.0) × nanofarad + (0).
   /// </summary>
   public static readonly Capacitance Picofarad = new ("picofarad", "pF", Nanofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtofarad. Defined as: (1.0/1000.0) × picofarad + (0).
   /// </summary>
   public static readonly Capacitance Femtofarad = new ("femtofarad", "fF", Picofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attofarad. Defined as: (1.0/1000.0) × femtofarad + (0).
   /// </summary>
   public static readonly Capacitance Attofarad = new ("attofarad", "aF", Femtofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptofarad. Defined as: (1.0/1000.0) × attofarad + (0).
   /// </summary>
   public static readonly Capacitance Zeptofarad = new ("zeptofarad", "zF", Attofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctofarad. Defined as: (1.0/1000.0) × zeptofarad + (0).
   /// </summary>
   public static readonly Capacitance Yoctofarad = new ("yoctofarad", "yF", Zeptofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontofarad. Defined as: (1.0/1000.0) × yoctofarad + (0).
   /// </summary>
   public static readonly Capacitance Rontofarad = new ("rontofarad", "rF", Yoctofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectofarad. Defined as: (1.0/1000.0) × rontofarad + (0).
   /// </summary>
   public static readonly Capacitance Quectofarad = new ("quectofarad", "qF", Rontofarad, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekafarad. Defined as: (10.0) × farad + (0).
   /// </summary>
   public static readonly Capacitance Dekafarad = new ("dekafarad", "daF", Farad, 10.0, 0);

   /// <summary>
   /// A(n) hectofarad. Defined as: (10.0) × dekafarad + (0).
   /// </summary>
   public static readonly Capacitance Hectofarad = new ("hectofarad", "hF", Dekafarad, 10.0, 0);

   /// <summary>
   /// A(n) kilofarad. Defined as: (10.0) × hectofarad + (0).
   /// </summary>
   public static readonly Capacitance Kilofarad = new ("kilofarad", "kF", Hectofarad, 10.0, 0);

   /// <summary>
   /// A(n) megafarad. Defined as: (1000.0) × kilofarad + (0).
   /// </summary>
   public static readonly Capacitance Megafarad = new ("megafarad", "MF", Kilofarad, 1000.0, 0);

   /// <summary>
   /// A(n) gigafarad. Defined as: (1000.0) × megafarad + (0).
   /// </summary>
   public static readonly Capacitance Gigafarad = new ("gigafarad", "GF", Megafarad, 1000.0, 0);

   /// <summary>
   /// A(n) terafarad. Defined as: (1000.0) × gigafarad + (0).
   /// </summary>
   public static readonly Capacitance Terafarad = new ("terafarad", "TF", Gigafarad, 1000.0, 0);

   /// <summary>
   /// A(n) petafarad. Defined as: (1000.0) × terafarad + (0).
   /// </summary>
   public static readonly Capacitance Petafarad = new ("petafarad", "PF", Terafarad, 1000.0, 0);

   /// <summary>
   /// A(n) exafarad. Defined as: (1000.0) × petafarad + (0).
   /// </summary>
   public static readonly Capacitance Exafarad = new ("exafarad", "EF", Petafarad, 1000.0, 0);

   /// <summary>
   /// A(n) zettafarad. Defined as: (1000.0) × exafarad + (0).
   /// </summary>
   public static readonly Capacitance Zettafarad = new ("zettafarad", "ZF", Exafarad, 1000.0, 0);

   /// <summary>
   /// A(n) yottafarad. Defined as: (1000.0) × zettafarad + (0).
   /// </summary>
   public static readonly Capacitance Yottafarad = new ("yottafarad", "YF", Zettafarad, 1000.0, 0);

   /// <summary>
   /// A(n) ronnafarad. Defined as: (1000.0) × yottafarad + (0).
   /// </summary>
   public static readonly Capacitance Ronnafarad = new ("ronnafarad", "RF", Yottafarad, 1000.0, 0);

   /// <summary>
   /// A(n) quettafarad. Defined as: (1000.0) × ronnafarad + (0).
   /// </summary>
   public static readonly Capacitance Quettafarad = new ("quettafarad", "QF", Ronnafarad, 1000.0, 0);
}
