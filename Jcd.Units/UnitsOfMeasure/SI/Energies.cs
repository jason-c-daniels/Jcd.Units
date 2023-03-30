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
/// International System of Units for measuring Energy.
/// </summary>
public class Energies : UnitOfMeasureEnumeration<Energies, Energy>
{
   /// <summary>
   /// joule, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Energy Joule = new ("joule", "J");

   /// <summary>
   /// decijoule, defined as: joule × 1.0/10.0
   /// </summary>
   public static readonly Energy Decijoule = new ("decijoule", "dJ", Joule, 1.0 / 10.0);

   /// <summary>
   /// centijoule, defined as: decijoule × 1.0/10.0
   /// </summary>
   public static readonly Energy Centijoule = new ("centijoule", "cJ", Decijoule, 1.0 / 10.0);

   /// <summary>
   /// millijoule, defined as: centijoule × 1.0/10.0
   /// </summary>
   public static readonly Energy Millijoule = new ("millijoule", "mJ", Centijoule, 1.0 / 10.0);

   /// <summary>
   /// microjoule, defined as: millijoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Microjoule = new ("microjoule", "μJ", Millijoule, 1.0 / 1000.0);

   /// <summary>
   /// nanojoule, defined as: microjoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Nanojoule = new ("nanojoule", "nJ", Microjoule, 1.0 / 1000.0);

   /// <summary>
   /// picojoule, defined as: nanojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Picojoule = new ("picojoule", "pJ", Nanojoule, 1.0 / 1000.0);

   /// <summary>
   /// femtojoule, defined as: picojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Femtojoule = new ("femtojoule", "fJ", Picojoule, 1.0 / 1000.0);

   /// <summary>
   /// attojoule, defined as: femtojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Attojoule = new ("attojoule", "aJ", Femtojoule, 1.0 / 1000.0);

   /// <summary>
   /// zeptojoule, defined as: attojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Zeptojoule = new ("zeptojoule", "zJ", Attojoule, 1.0 / 1000.0);

   /// <summary>
   /// yoctojoule, defined as: zeptojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Yoctojoule = new ("yoctojoule", "yJ", Zeptojoule, 1.0 / 1000.0);

   /// <summary>
   /// rontojoule, defined as: yoctojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Rontojoule = new ("rontojoule", "rJ", Yoctojoule, 1.0 / 1000.0);

   /// <summary>
   /// quectojoule, defined as: rontojoule × 1.0/1000.0
   /// </summary>
   public static readonly Energy Quectojoule = new ("quectojoule", "qJ", Rontojoule, 1.0 / 1000.0);

   /// <summary>
   /// dekajoule, defined as: joule × 10.0
   /// </summary>
   public static readonly Energy Dekajoule = new ("dekajoule", "daJ", Joule, 10.0);

   /// <summary>
   /// hectojoule, defined as: dekajoule × 10.0
   /// </summary>
   public static readonly Energy Hectojoule = new ("hectojoule", "hJ", Dekajoule, 10.0);

   /// <summary>
   /// kilojoule, defined as: hectojoule × 10.0
   /// </summary>
   public static readonly Energy Kilojoule = new ("kilojoule", "kJ", Hectojoule, 10.0);

   /// <summary>
   /// megajoule, defined as: kilojoule × 1000.0
   /// </summary>
   public static readonly Energy Megajoule = new ("megajoule", "MJ", Kilojoule, 1000.0);

   /// <summary>
   /// gigajoule, defined as: megajoule × 1000.0
   /// </summary>
   public static readonly Energy Gigajoule = new ("gigajoule", "GJ", Megajoule, 1000.0);

   /// <summary>
   /// terajoule, defined as: gigajoule × 1000.0
   /// </summary>
   public static readonly Energy Terajoule = new ("terajoule", "TJ", Gigajoule, 1000.0);

   /// <summary>
   /// petajoule, defined as: terajoule × 1000.0
   /// </summary>
   public static readonly Energy Petajoule = new ("petajoule", "PJ", Terajoule, 1000.0);

   /// <summary>
   /// exajoule, defined as: petajoule × 1000.0
   /// </summary>
   public static readonly Energy Exajoule = new ("exajoule", "EJ", Petajoule, 1000.0);

   /// <summary>
   /// zettajoule, defined as: exajoule × 1000.0
   /// </summary>
   public static readonly Energy Zettajoule = new ("zettajoule", "ZJ", Exajoule, 1000.0);

   /// <summary>
   /// yottajoule, defined as: zettajoule × 1000.0
   /// </summary>
   public static readonly Energy Yottajoule = new ("yottajoule", "YJ", Zettajoule, 1000.0);

   /// <summary>
   /// ronnajoule, defined as: yottajoule × 1000.0
   /// </summary>
   public static readonly Energy Ronnajoule = new ("ronnajoule", "RJ", Yottajoule, 1000.0);

   /// <summary>
   /// quettajoule, defined as: ronnajoule × 1000.0
   /// </summary>
   public static readonly Energy Quettajoule = new ("quettajoule", "QJ", Ronnajoule, 1000.0);

   /// <summary>
   /// calorie, defined as: joule × 4.184
   /// </summary>
   public static readonly Energy Calorie = new ("calorie", "c", Joule, 4.184);

   /// <summary>
   /// decicalorie, defined as: calorie × 1.0/10.0
   /// </summary>
   public static readonly Energy Decicalorie = new ("decicalorie", "dc", Calorie, 1.0 / 10.0);

   /// <summary>
   /// centicalorie, defined as: decicalorie × 1.0/10.0
   /// </summary>
   public static readonly Energy Centicalorie = new ("centicalorie", "cc", Decicalorie, 1.0 / 10.0);

   /// <summary>
   /// millicalorie, defined as: centicalorie × 1.0/10.0
   /// </summary>
   public static readonly Energy Millicalorie = new ("millicalorie", "mc", Centicalorie, 1.0 / 10.0);

   /// <summary>
   /// microcalorie, defined as: millicalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Microcalorie = new ("microcalorie", "μc", Millicalorie, 1.0 / 1000.0);

   /// <summary>
   /// nanocalorie, defined as: microcalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Nanocalorie = new ("nanocalorie", "nc", Microcalorie, 1.0 / 1000.0);

   /// <summary>
   /// picocalorie, defined as: nanocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Picocalorie = new ("picocalorie", "pc", Nanocalorie, 1.0 / 1000.0);

   /// <summary>
   /// femtocalorie, defined as: picocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Femtocalorie = new ("femtocalorie", "fc", Picocalorie, 1.0 / 1000.0);

   /// <summary>
   /// attocalorie, defined as: femtocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Attocalorie = new ("attocalorie", "ac", Femtocalorie, 1.0 / 1000.0);

   /// <summary>
   /// zeptocalorie, defined as: attocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Zeptocalorie = new ("zeptocalorie", "zc", Attocalorie, 1.0 / 1000.0);

   /// <summary>
   /// yoctocalorie, defined as: zeptocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Yoctocalorie = new ("yoctocalorie", "yc", Zeptocalorie, 1.0 / 1000.0);

   /// <summary>
   /// rontocalorie, defined as: yoctocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Rontocalorie = new ("rontocalorie", "rc", Yoctocalorie, 1.0 / 1000.0);

   /// <summary>
   /// quectocalorie, defined as: rontocalorie × 1.0/1000.0
   /// </summary>
   public static readonly Energy Quectocalorie = new ("quectocalorie", "qc", Rontocalorie, 1.0 / 1000.0);

   /// <summary>
   /// dekacalorie, defined as: calorie × 10.0
   /// </summary>
   public static readonly Energy Dekacalorie = new ("dekacalorie", "dac", Calorie, 10.0);

   /// <summary>
   /// hectocalorie, defined as: dekacalorie × 10.0
   /// </summary>
   public static readonly Energy Hectocalorie = new ("hectocalorie", "hc", Dekacalorie, 10.0);

   /// <summary>
   /// kilocalorie, defined as: hectocalorie × 10.0
   /// </summary>
   public static readonly Energy Kilocalorie = new ("kilocalorie", "kc", Hectocalorie, 10.0);

   /// <summary>
   /// megacalorie, defined as: kilocalorie × 1000.0
   /// </summary>
   public static readonly Energy Megacalorie = new ("megacalorie", "Mc", Kilocalorie, 1000.0);

   /// <summary>
   /// gigacalorie, defined as: megacalorie × 1000.0
   /// </summary>
   public static readonly Energy Gigacalorie = new ("gigacalorie", "Gc", Megacalorie, 1000.0);

   /// <summary>
   /// teracalorie, defined as: gigacalorie × 1000.0
   /// </summary>
   public static readonly Energy Teracalorie = new ("teracalorie", "Tc", Gigacalorie, 1000.0);

   /// <summary>
   /// petacalorie, defined as: teracalorie × 1000.0
   /// </summary>
   public static readonly Energy Petacalorie = new ("petacalorie", "Pc", Teracalorie, 1000.0);

   /// <summary>
   /// exacalorie, defined as: petacalorie × 1000.0
   /// </summary>
   public static readonly Energy Exacalorie = new ("exacalorie", "Ec", Petacalorie, 1000.0);

   /// <summary>
   /// zettacalorie, defined as: exacalorie × 1000.0
   /// </summary>
   public static readonly Energy Zettacalorie = new ("zettacalorie", "Zc", Exacalorie, 1000.0);

   /// <summary>
   /// yottacalorie, defined as: zettacalorie × 1000.0
   /// </summary>
   public static readonly Energy Yottacalorie = new ("yottacalorie", "Yc", Zettacalorie, 1000.0);

   /// <summary>
   /// ronnacalorie, defined as: yottacalorie × 1000.0
   /// </summary>
   public static readonly Energy Ronnacalorie = new ("ronnacalorie", "Rc", Yottacalorie, 1000.0);

   /// <summary>
   /// quettacalorie, defined as: ronnacalorie × 1000.0
   /// </summary>
   public static readonly Energy Quettacalorie = new ("quettacalorie", "Qc", Ronnacalorie, 1000.0);

   /// <summary>
   /// Calorie (Food), defined as: calorie × 1000.0
   /// </summary>
   public static readonly Energy CalorieFood = new ("Calorie (Food)", "C", Calorie, 1000.0);
}
