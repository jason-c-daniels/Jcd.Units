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
   /// decihenry defined such that: henry = dH × 1.0/10.0.
   /// </summary>
   public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centihenry defined such that: decihenry = cH × 1.0/10.0.
   /// </summary>
   public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millihenry defined such that: centihenry = mH × 1.0/10.0.
   /// </summary>
   public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microhenry defined such that: millihenry = μH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanohenry defined such that: microhenry = nH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picohenry defined such that: nanohenry = pH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtohenry defined such that: picohenry = fH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attohenry defined such that: femtohenry = aH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptohenry defined such that: attohenry = zH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctohenry defined such that: zeptohenry = yH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontohenry defined such that: yoctohenry = rH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectohenry defined such that: rontohenry = qH × 1.0/1000.0.
   /// </summary>
   public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekahenry defined such that: henry = daH × 10.0.
   /// </summary>
   public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10.0, system: "SI");

   /// <summary>
   /// hectohenry defined such that: dekahenry = hH × 10.0.
   /// </summary>
   public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10.0, system: "SI");

   /// <summary>
   /// kilohenry defined such that: hectohenry = kH × 10.0.
   /// </summary>
   public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10.0, system: "SI");

   /// <summary>
   /// megahenry defined such that: kilohenry = MH × 1000.0.
   /// </summary>
   public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000.0, system: "SI");

   /// <summary>
   /// gigahenry defined such that: megahenry = GH × 1000.0.
   /// </summary>
   public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000.0, system: "SI");

   /// <summary>
   /// terahenry defined such that: gigahenry = TH × 1000.0.
   /// </summary>
   public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000.0, system: "SI");

   /// <summary>
   /// petahenry defined such that: terahenry = PH × 1000.0.
   /// </summary>
   public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000.0, system: "SI");

   /// <summary>
   /// exahenry defined such that: petahenry = EH × 1000.0.
   /// </summary>
   public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000.0, system: "SI");

   /// <summary>
   /// zettahenry defined such that: exahenry = ZH × 1000.0.
   /// </summary>
   public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000.0, system: "SI");

   /// <summary>
   /// yottahenry defined such that: zettahenry = YH × 1000.0.
   /// </summary>
   public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000.0, system: "SI");

   /// <summary>
   /// ronnahenry defined such that: yottahenry = RH × 1000.0.
   /// </summary>
   public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000.0, system: "SI");

   /// <summary>
   /// quettahenry defined such that: ronnahenry = QH × 1000.0.
   /// </summary>
   public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000.0, system: "SI");
}
