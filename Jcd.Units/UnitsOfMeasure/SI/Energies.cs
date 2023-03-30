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
   /// A(n) joule.
   /// </summary>
   public static readonly Energy Joule = new ("joule", "J");

   /// <summary>
   /// A(n) decijoule. Defined as: 1.0/10.0 × joule.
   /// </summary>
   public static readonly Energy Decijoule = new ("decijoule", "dJ", Joule, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centijoule. Defined as: 1.0/10.0 × decijoule.
   /// </summary>
   public static readonly Energy Centijoule = new ("centijoule", "cJ", Decijoule, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millijoule. Defined as: 1.0/10.0 × centijoule.
   /// </summary>
   public static readonly Energy Millijoule = new ("millijoule", "mJ", Centijoule, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microjoule. Defined as: 1.0/1000.0 × millijoule.
   /// </summary>
   public static readonly Energy Microjoule = new ("microjoule", "μJ", Millijoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanojoule. Defined as: 1.0/1000.0 × microjoule.
   /// </summary>
   public static readonly Energy Nanojoule = new ("nanojoule", "nJ", Microjoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picojoule. Defined as: 1.0/1000.0 × nanojoule.
   /// </summary>
   public static readonly Energy Picojoule = new ("picojoule", "pJ", Nanojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtojoule. Defined as: 1.0/1000.0 × picojoule.
   /// </summary>
   public static readonly Energy Femtojoule = new ("femtojoule", "fJ", Picojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attojoule. Defined as: 1.0/1000.0 × femtojoule.
   /// </summary>
   public static readonly Energy Attojoule = new ("attojoule", "aJ", Femtojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptojoule. Defined as: 1.0/1000.0 × attojoule.
   /// </summary>
   public static readonly Energy Zeptojoule = new ("zeptojoule", "zJ", Attojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctojoule. Defined as: 1.0/1000.0 × zeptojoule.
   /// </summary>
   public static readonly Energy Yoctojoule = new ("yoctojoule", "yJ", Zeptojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontojoule. Defined as: 1.0/1000.0 × yoctojoule.
   /// </summary>
   public static readonly Energy Rontojoule = new ("rontojoule", "rJ", Yoctojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectojoule. Defined as: 1.0/1000.0 × rontojoule.
   /// </summary>
   public static readonly Energy Quectojoule = new ("quectojoule", "qJ", Rontojoule, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekajoule. Defined as: 10.0 × joule.
   /// </summary>
   public static readonly Energy Dekajoule = new ("dekajoule", "daJ", Joule, 10.0, 0);

   /// <summary>
   /// A(n) hectojoule. Defined as: 10.0 × dekajoule.
   /// </summary>
   public static readonly Energy Hectojoule = new ("hectojoule", "hJ", Dekajoule, 10.0, 0);

   /// <summary>
   /// A(n) kilojoule. Defined as: 10.0 × hectojoule.
   /// </summary>
   public static readonly Energy Kilojoule = new ("kilojoule", "kJ", Hectojoule, 10.0, 0);

   /// <summary>
   /// A(n) megajoule. Defined as: 1000.0 × kilojoule.
   /// </summary>
   public static readonly Energy Megajoule = new ("megajoule", "MJ", Kilojoule, 1000.0, 0);

   /// <summary>
   /// A(n) gigajoule. Defined as: 1000.0 × megajoule.
   /// </summary>
   public static readonly Energy Gigajoule = new ("gigajoule", "GJ", Megajoule, 1000.0, 0);

   /// <summary>
   /// A(n) terajoule. Defined as: 1000.0 × gigajoule.
   /// </summary>
   public static readonly Energy Terajoule = new ("terajoule", "TJ", Gigajoule, 1000.0, 0);

   /// <summary>
   /// A(n) petajoule. Defined as: 1000.0 × terajoule.
   /// </summary>
   public static readonly Energy Petajoule = new ("petajoule", "PJ", Terajoule, 1000.0, 0);

   /// <summary>
   /// A(n) exajoule. Defined as: 1000.0 × petajoule.
   /// </summary>
   public static readonly Energy Exajoule = new ("exajoule", "EJ", Petajoule, 1000.0, 0);

   /// <summary>
   /// A(n) zettajoule. Defined as: 1000.0 × exajoule.
   /// </summary>
   public static readonly Energy Zettajoule = new ("zettajoule", "ZJ", Exajoule, 1000.0, 0);

   /// <summary>
   /// A(n) yottajoule. Defined as: 1000.0 × zettajoule.
   /// </summary>
   public static readonly Energy Yottajoule = new ("yottajoule", "YJ", Zettajoule, 1000.0, 0);

   /// <summary>
   /// A(n) ronnajoule. Defined as: 1000.0 × yottajoule.
   /// </summary>
   public static readonly Energy Ronnajoule = new ("ronnajoule", "RJ", Yottajoule, 1000.0, 0);

   /// <summary>
   /// A(n) quettajoule. Defined as: 1000.0 × ronnajoule.
   /// </summary>
   public static readonly Energy Quettajoule = new ("quettajoule", "QJ", Ronnajoule, 1000.0, 0);

   /// <summary>
   /// A(n) calorie. Defined as: 4.184 × joule.
   /// </summary>
   public static readonly Energy Calorie = new ("calorie", "c", Joule, 4.184, 0);

   /// <summary>
   /// A(n) decicalorie. Defined as: 1.0/10.0 × calorie.
   /// </summary>
   public static readonly Energy Decicalorie = new ("decicalorie", "dc", Calorie, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centicalorie. Defined as: 1.0/10.0 × decicalorie.
   /// </summary>
   public static readonly Energy Centicalorie = new ("centicalorie", "cc", Decicalorie, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millicalorie. Defined as: 1.0/10.0 × centicalorie.
   /// </summary>
   public static readonly Energy Millicalorie = new ("millicalorie", "mc", Centicalorie, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microcalorie. Defined as: 1.0/1000.0 × millicalorie.
   /// </summary>
   public static readonly Energy Microcalorie = new ("microcalorie", "μc", Millicalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanocalorie. Defined as: 1.0/1000.0 × microcalorie.
   /// </summary>
   public static readonly Energy Nanocalorie = new ("nanocalorie", "nc", Microcalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picocalorie. Defined as: 1.0/1000.0 × nanocalorie.
   /// </summary>
   public static readonly Energy Picocalorie = new ("picocalorie", "pc", Nanocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtocalorie. Defined as: 1.0/1000.0 × picocalorie.
   /// </summary>
   public static readonly Energy Femtocalorie = new ("femtocalorie", "fc", Picocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attocalorie. Defined as: 1.0/1000.0 × femtocalorie.
   /// </summary>
   public static readonly Energy Attocalorie = new ("attocalorie", "ac", Femtocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptocalorie. Defined as: 1.0/1000.0 × attocalorie.
   /// </summary>
   public static readonly Energy Zeptocalorie = new ("zeptocalorie", "zc", Attocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctocalorie. Defined as: 1.0/1000.0 × zeptocalorie.
   /// </summary>
   public static readonly Energy Yoctocalorie = new ("yoctocalorie", "yc", Zeptocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontocalorie. Defined as: 1.0/1000.0 × yoctocalorie.
   /// </summary>
   public static readonly Energy Rontocalorie = new ("rontocalorie", "rc", Yoctocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectocalorie. Defined as: 1.0/1000.0 × rontocalorie.
   /// </summary>
   public static readonly Energy Quectocalorie = new ("quectocalorie", "qc", Rontocalorie, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekacalorie. Defined as: 10.0 × calorie.
   /// </summary>
   public static readonly Energy Dekacalorie = new ("dekacalorie", "dac", Calorie, 10.0, 0);

   /// <summary>
   /// A(n) hectocalorie. Defined as: 10.0 × dekacalorie.
   /// </summary>
   public static readonly Energy Hectocalorie = new ("hectocalorie", "hc", Dekacalorie, 10.0, 0);

   /// <summary>
   /// A(n) kilocalorie. Defined as: 10.0 × hectocalorie.
   /// </summary>
   public static readonly Energy Kilocalorie = new ("kilocalorie", "kc", Hectocalorie, 10.0, 0);

   /// <summary>
   /// A(n) megacalorie. Defined as: 1000.0 × kilocalorie.
   /// </summary>
   public static readonly Energy Megacalorie = new ("megacalorie", "Mc", Kilocalorie, 1000.0, 0);

   /// <summary>
   /// A(n) gigacalorie. Defined as: 1000.0 × megacalorie.
   /// </summary>
   public static readonly Energy Gigacalorie = new ("gigacalorie", "Gc", Megacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) teracalorie. Defined as: 1000.0 × gigacalorie.
   /// </summary>
   public static readonly Energy Teracalorie = new ("teracalorie", "Tc", Gigacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) petacalorie. Defined as: 1000.0 × teracalorie.
   /// </summary>
   public static readonly Energy Petacalorie = new ("petacalorie", "Pc", Teracalorie, 1000.0, 0);

   /// <summary>
   /// A(n) exacalorie. Defined as: 1000.0 × petacalorie.
   /// </summary>
   public static readonly Energy Exacalorie = new ("exacalorie", "Ec", Petacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) zettacalorie. Defined as: 1000.0 × exacalorie.
   /// </summary>
   public static readonly Energy Zettacalorie = new ("zettacalorie", "Zc", Exacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) yottacalorie. Defined as: 1000.0 × zettacalorie.
   /// </summary>
   public static readonly Energy Yottacalorie = new ("yottacalorie", "Yc", Zettacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) ronnacalorie. Defined as: 1000.0 × yottacalorie.
   /// </summary>
   public static readonly Energy Ronnacalorie = new ("ronnacalorie", "Rc", Yottacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) quettacalorie. Defined as: 1000.0 × ronnacalorie.
   /// </summary>
   public static readonly Energy Quettacalorie = new ("quettacalorie", "Qc", Ronnacalorie, 1000.0, 0);

   /// <summary>
   /// A(n) Calorie (Food). Defined as: 1000.0 × calorie.
   /// </summary>
   public static readonly Energy CalorieFood = new ("Calorie (Food)", "C", Calorie, 1000.0, 0);
}
