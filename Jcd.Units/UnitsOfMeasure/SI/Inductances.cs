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
   /// A(n) henry.
   /// </summary>
   public static readonly Inductance Henry = new ("henry", "H");

   /// <summary>
   /// A(n) decihenry. Defined as: 1.0/10.0 × henry.
   /// </summary>
   public static readonly Inductance Decihenry = new ("decihenry", "dH", Henry, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centihenry. Defined as: 1.0/10.0 × decihenry.
   /// </summary>
   public static readonly Inductance Centihenry = new ("centihenry", "cH", Decihenry, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millihenry. Defined as: 1.0/10.0 × centihenry.
   /// </summary>
   public static readonly Inductance Millihenry = new ("millihenry", "mH", Centihenry, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microhenry. Defined as: 1.0/1000.0 × millihenry.
   /// </summary>
   public static readonly Inductance Microhenry = new ("microhenry", "μH", Millihenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanohenry. Defined as: 1.0/1000.0 × microhenry.
   /// </summary>
   public static readonly Inductance Nanohenry = new ("nanohenry", "nH", Microhenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picohenry. Defined as: 1.0/1000.0 × nanohenry.
   /// </summary>
   public static readonly Inductance Picohenry = new ("picohenry", "pH", Nanohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtohenry. Defined as: 1.0/1000.0 × picohenry.
   /// </summary>
   public static readonly Inductance Femtohenry = new ("femtohenry", "fH", Picohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attohenry. Defined as: 1.0/1000.0 × femtohenry.
   /// </summary>
   public static readonly Inductance Attohenry = new ("attohenry", "aH", Femtohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptohenry. Defined as: 1.0/1000.0 × attohenry.
   /// </summary>
   public static readonly Inductance Zeptohenry = new ("zeptohenry", "zH", Attohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctohenry. Defined as: 1.0/1000.0 × zeptohenry.
   /// </summary>
   public static readonly Inductance Yoctohenry = new ("yoctohenry", "yH", Zeptohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontohenry. Defined as: 1.0/1000.0 × yoctohenry.
   /// </summary>
   public static readonly Inductance Rontohenry = new ("rontohenry", "rH", Yoctohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectohenry. Defined as: 1.0/1000.0 × rontohenry.
   /// </summary>
   public static readonly Inductance Quectohenry = new ("quectohenry", "qH", Rontohenry, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekahenry. Defined as: 10.0 × henry.
   /// </summary>
   public static readonly Inductance Dekahenry = new ("dekahenry", "daH", Henry, 10.0, 0);

   /// <summary>
   /// A(n) hectohenry. Defined as: 10.0 × dekahenry.
   /// </summary>
   public static readonly Inductance Hectohenry = new ("hectohenry", "hH", Dekahenry, 10.0, 0);

   /// <summary>
   /// A(n) kilohenry. Defined as: 10.0 × hectohenry.
   /// </summary>
   public static readonly Inductance Kilohenry = new ("kilohenry", "kH", Hectohenry, 10.0, 0);

   /// <summary>
   /// A(n) megahenry. Defined as: 1000.0 × kilohenry.
   /// </summary>
   public static readonly Inductance Megahenry = new ("megahenry", "MH", Kilohenry, 1000.0, 0);

   /// <summary>
   /// A(n) gigahenry. Defined as: 1000.0 × megahenry.
   /// </summary>
   public static readonly Inductance Gigahenry = new ("gigahenry", "GH", Megahenry, 1000.0, 0);

   /// <summary>
   /// A(n) terahenry. Defined as: 1000.0 × gigahenry.
   /// </summary>
   public static readonly Inductance Terahenry = new ("terahenry", "TH", Gigahenry, 1000.0, 0);

   /// <summary>
   /// A(n) petahenry. Defined as: 1000.0 × terahenry.
   /// </summary>
   public static readonly Inductance Petahenry = new ("petahenry", "PH", Terahenry, 1000.0, 0);

   /// <summary>
   /// A(n) exahenry. Defined as: 1000.0 × petahenry.
   /// </summary>
   public static readonly Inductance Exahenry = new ("exahenry", "EH", Petahenry, 1000.0, 0);

   /// <summary>
   /// A(n) zettahenry. Defined as: 1000.0 × exahenry.
   /// </summary>
   public static readonly Inductance Zettahenry = new ("zettahenry", "ZH", Exahenry, 1000.0, 0);

   /// <summary>
   /// A(n) yottahenry. Defined as: 1000.0 × zettahenry.
   /// </summary>
   public static readonly Inductance Yottahenry = new ("yottahenry", "YH", Zettahenry, 1000.0, 0);

   /// <summary>
   /// A(n) ronnahenry. Defined as: 1000.0 × yottahenry.
   /// </summary>
   public static readonly Inductance Ronnahenry = new ("ronnahenry", "RH", Yottahenry, 1000.0, 0);

   /// <summary>
   /// A(n) quettahenry. Defined as: 1000.0 × ronnahenry.
   /// </summary>
   public static readonly Inductance Quettahenry = new ("quettahenry", "QH", Ronnahenry, 1000.0, 0);
}
