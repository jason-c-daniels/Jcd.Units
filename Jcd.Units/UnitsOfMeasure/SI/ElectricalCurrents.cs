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
/// International System of Units for measuring Electrical Current.
/// </summary>
public class ElectricalCurrents : UnitOfMeasureEnumeration<ElectricalCurrents, ElectricalCurrent>
{
   /// <summary>
   /// A(n) ampere.
   /// </summary>
   public static readonly ElectricalCurrent Ampere = new ("ampere", "A");

   /// <summary>
   /// A(n) deciampere. Defined as: 1.0/10.0 × ampere.
   /// </summary>
   public static readonly ElectricalCurrent Deciampere = new ("deciampere", "dA", Ampere, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centiampere. Defined as: 1.0/10.0 × deciampere.
   /// </summary>
   public static readonly ElectricalCurrent Centiampere = new ("centiampere", "cA", Deciampere, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milliampere. Defined as: 1.0/10.0 × centiampere.
   /// </summary>
   public static readonly ElectricalCurrent Milliampere = new ("milliampere", "mA", Centiampere, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microampere. Defined as: 1.0/1000.0 × milliampere.
   /// </summary>
   public static readonly ElectricalCurrent Microampere = new ("microampere", "μA", Milliampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanoampere. Defined as: 1.0/1000.0 × microampere.
   /// </summary>
   public static readonly ElectricalCurrent Nanoampere = new ("nanoampere", "nA", Microampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picoampere. Defined as: 1.0/1000.0 × nanoampere.
   /// </summary>
   public static readonly ElectricalCurrent Picoampere = new ("picoampere", "pA", Nanoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtoampere. Defined as: 1.0/1000.0 × picoampere.
   /// </summary>
   public static readonly ElectricalCurrent Femtoampere = new ("femtoampere", "fA", Picoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attoampere. Defined as: 1.0/1000.0 × femtoampere.
   /// </summary>
   public static readonly ElectricalCurrent Attoampere = new ("attoampere", "aA", Femtoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptoampere. Defined as: 1.0/1000.0 × attoampere.
   /// </summary>
   public static readonly ElectricalCurrent Zeptoampere = new ("zeptoampere", "zA", Attoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctoampere. Defined as: 1.0/1000.0 × zeptoampere.
   /// </summary>
   public static readonly ElectricalCurrent Yoctoampere = new ("yoctoampere", "yA", Zeptoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontoampere. Defined as: 1.0/1000.0 × yoctoampere.
   /// </summary>
   public static readonly ElectricalCurrent Rontoampere = new ("rontoampere", "rA", Yoctoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectoampere. Defined as: 1.0/1000.0 × rontoampere.
   /// </summary>
   public static readonly ElectricalCurrent Quectoampere = new ("quectoampere", "qA", Rontoampere, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekaampere. Defined as: 10.0 × ampere.
   /// </summary>
   public static readonly ElectricalCurrent Dekaampere = new ("dekaampere", "daA", Ampere, 10.0, 0);

   /// <summary>
   /// A(n) hectoampere. Defined as: 10.0 × dekaampere.
   /// </summary>
   public static readonly ElectricalCurrent Hectoampere = new ("hectoampere", "hA", Dekaampere, 10.0, 0);

   /// <summary>
   /// A(n) kiloampere. Defined as: 10.0 × hectoampere.
   /// </summary>
   public static readonly ElectricalCurrent Kiloampere = new ("kiloampere", "kA", Hectoampere, 10.0, 0);

   /// <summary>
   /// A(n) megaampere. Defined as: 1000.0 × kiloampere.
   /// </summary>
   public static readonly ElectricalCurrent Megaampere = new ("megaampere", "MA", Kiloampere, 1000.0, 0);

   /// <summary>
   /// A(n) gigaampere. Defined as: 1000.0 × megaampere.
   /// </summary>
   public static readonly ElectricalCurrent Gigaampere = new ("gigaampere", "GA", Megaampere, 1000.0, 0);

   /// <summary>
   /// A(n) teraampere. Defined as: 1000.0 × gigaampere.
   /// </summary>
   public static readonly ElectricalCurrent Teraampere = new ("teraampere", "TA", Gigaampere, 1000.0, 0);

   /// <summary>
   /// A(n) petaampere. Defined as: 1000.0 × teraampere.
   /// </summary>
   public static readonly ElectricalCurrent Petaampere = new ("petaampere", "PA", Teraampere, 1000.0, 0);

   /// <summary>
   /// A(n) exaampere. Defined as: 1000.0 × petaampere.
   /// </summary>
   public static readonly ElectricalCurrent Exaampere = new ("exaampere", "EA", Petaampere, 1000.0, 0);

   /// <summary>
   /// A(n) zettaampere. Defined as: 1000.0 × exaampere.
   /// </summary>
   public static readonly ElectricalCurrent Zettaampere = new ("zettaampere", "ZA", Exaampere, 1000.0, 0);

   /// <summary>
   /// A(n) yottaampere. Defined as: 1000.0 × zettaampere.
   /// </summary>
   public static readonly ElectricalCurrent Yottaampere = new ("yottaampere", "YA", Zettaampere, 1000.0, 0);

   /// <summary>
   /// A(n) ronnaampere. Defined as: 1000.0 × yottaampere.
   /// </summary>
   public static readonly ElectricalCurrent Ronnaampere = new ("ronnaampere", "RA", Yottaampere, 1000.0, 0);

   /// <summary>
   /// A(n) quettaampere. Defined as: 1000.0 × ronnaampere.
   /// </summary>
   public static readonly ElectricalCurrent Quettaampere = new ("quettaampere", "QA", Ronnaampere, 1000.0, 0);
}
