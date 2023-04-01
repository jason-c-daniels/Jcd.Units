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
/// International System of Units for measuring Inductance.
/// </summary>
public class Inductances : UnitOfMeasureEnumeration<Inductances, Inductance>
{
   /// <summary>
   /// henry, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Inductance Henry = new ("henry", "H", system: "SI");

   /// <summary>
   /// decihenry, defined as: henry × 1.0/10.0
   /// </summary>
   public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centihenry, defined as: decihenry × 1.0/10.0
   /// </summary>
   public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millihenry, defined as: centihenry × 1.0/10.0
   /// </summary>
   public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microhenry, defined as: millihenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanohenry, defined as: microhenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picohenry, defined as: nanohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtohenry, defined as: picohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attohenry, defined as: femtohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptohenry, defined as: attohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctohenry, defined as: zeptohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontohenry, defined as: yoctohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectohenry, defined as: rontohenry × 1.0/1000.0
   /// </summary>
   public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekahenry, defined as: henry × 10.0
   /// </summary>
   public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10.0, system: "SI");

   /// <summary>
   /// hectohenry, defined as: dekahenry × 10.0
   /// </summary>
   public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10.0, system: "SI");

   /// <summary>
   /// kilohenry, defined as: hectohenry × 10.0
   /// </summary>
   public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10.0, system: "SI");

   /// <summary>
   /// megahenry, defined as: kilohenry × 1000.0
   /// </summary>
   public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000.0, system: "SI");

   /// <summary>
   /// gigahenry, defined as: megahenry × 1000.0
   /// </summary>
   public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000.0, system: "SI");

   /// <summary>
   /// terahenry, defined as: gigahenry × 1000.0
   /// </summary>
   public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000.0, system: "SI");

   /// <summary>
   /// petahenry, defined as: terahenry × 1000.0
   /// </summary>
   public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000.0, system: "SI");

   /// <summary>
   /// exahenry, defined as: petahenry × 1000.0
   /// </summary>
   public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000.0, system: "SI");

   /// <summary>
   /// zettahenry, defined as: exahenry × 1000.0
   /// </summary>
   public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000.0, system: "SI");

   /// <summary>
   /// yottahenry, defined as: zettahenry × 1000.0
   /// </summary>
   public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000.0, system: "SI");

   /// <summary>
   /// ronnahenry, defined as: yottahenry × 1000.0
   /// </summary>
   public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000.0, system: "SI");

   /// <summary>
   /// quettahenry, defined as: ronnahenry × 1000.0
   /// </summary>
   public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000.0, system: "SI");
}
