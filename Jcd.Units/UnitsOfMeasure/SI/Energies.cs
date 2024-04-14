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
   public static readonly Energy Joule = new("joule", "J", system: "SI");
   
   /// <summary>
   /// decijoule defined such that: joule = dJ × 1.0/10.0.
   /// </summary>
   public static readonly Energy Decijoule = new("decijoule", "dJ", Joule, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centijoule defined such that: decijoule = cJ × 1.0/10.0.
   /// </summary>
   public static readonly Energy Centijoule = new("centijoule", "cJ", Decijoule, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millijoule defined such that: centijoule = mJ × 1.0/10.0.
   /// </summary>
   public static readonly Energy Millijoule = new("millijoule", "mJ", Centijoule, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microjoule defined such that: millijoule = μJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Microjoule = new("microjoule", "μJ", Millijoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanojoule defined such that: microjoule = nJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Nanojoule = new("nanojoule", "nJ", Microjoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picojoule defined such that: nanojoule = pJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Picojoule = new("picojoule", "pJ", Nanojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtojoule defined such that: picojoule = fJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Femtojoule = new("femtojoule", "fJ", Picojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attojoule defined such that: femtojoule = aJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Attojoule = new("attojoule", "aJ", Femtojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptojoule defined such that: attojoule = zJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Zeptojoule = new("zeptojoule", "zJ", Attojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctojoule defined such that: zeptojoule = yJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Yoctojoule = new("yoctojoule", "yJ", Zeptojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontojoule defined such that: yoctojoule = rJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Rontojoule = new("rontojoule", "rJ", Yoctojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectojoule defined such that: rontojoule = qJ × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Quectojoule = new("quectojoule", "qJ", Rontojoule, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekajoule defined such that: joule = daJ × 10.0.
   /// </summary>
   public static readonly Energy Dekajoule = new("dekajoule", "daJ", Joule, 10.0, system: "SI");
   
   /// <summary>
   /// hectojoule defined such that: dekajoule = hJ × 10.0.
   /// </summary>
   public static readonly Energy Hectojoule = new("hectojoule", "hJ", Dekajoule, 10.0, system: "SI");
   
   /// <summary>
   /// kilojoule defined such that: hectojoule = kJ × 10.0.
   /// </summary>
   public static readonly Energy Kilojoule = new("kilojoule", "kJ", Hectojoule, 10.0, system: "SI");
   
   /// <summary>
   /// megajoule defined such that: kilojoule = MJ × 1000.0.
   /// </summary>
   public static readonly Energy Megajoule = new("megajoule", "MJ", Kilojoule, 1000.0, system: "SI");
   
   /// <summary>
   /// gigajoule defined such that: megajoule = GJ × 1000.0.
   /// </summary>
   public static readonly Energy Gigajoule = new("gigajoule", "GJ", Megajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// terajoule defined such that: gigajoule = TJ × 1000.0.
   /// </summary>
   public static readonly Energy Terajoule = new("terajoule", "TJ", Gigajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// petajoule defined such that: terajoule = PJ × 1000.0.
   /// </summary>
   public static readonly Energy Petajoule = new("petajoule", "PJ", Terajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// exajoule defined such that: petajoule = EJ × 1000.0.
   /// </summary>
   public static readonly Energy Exajoule = new("exajoule", "EJ", Petajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// zettajoule defined such that: exajoule = ZJ × 1000.0.
   /// </summary>
   public static readonly Energy Zettajoule = new("zettajoule", "ZJ", Exajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// yottajoule defined such that: zettajoule = YJ × 1000.0.
   /// </summary>
   public static readonly Energy Yottajoule = new("yottajoule", "YJ", Zettajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnajoule defined such that: yottajoule = RJ × 1000.0.
   /// </summary>
   public static readonly Energy Ronnajoule = new("ronnajoule", "RJ", Yottajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// quettajoule defined such that: ronnajoule = QJ × 1000.0.
   /// </summary>
   public static readonly Energy Quettajoule = new("quettajoule", "QJ", Ronnajoule, 1000.0, system: "SI");
   
   /// <summary>
   /// calorie defined such that: joule = c × 4.184.
   /// </summary>
   public static readonly Energy Calorie = new("calorie", "c", Joule, 4.184, system: "SI");
   
   /// <summary>
   /// decicalorie defined such that: calorie = dc × 1.0/10.0.
   /// </summary>
   public static readonly Energy Decicalorie = new("decicalorie", "dc", Calorie, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centicalorie defined such that: decicalorie = cc × 1.0/10.0.
   /// </summary>
   public static readonly Energy Centicalorie = new("centicalorie", "cc", Decicalorie, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millicalorie defined such that: centicalorie = mc × 1.0/10.0.
   /// </summary>
   public static readonly Energy Millicalorie = new("millicalorie", "mc", Centicalorie, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microcalorie defined such that: millicalorie = μc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Microcalorie = new("microcalorie", "μc", Millicalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanocalorie defined such that: microcalorie = nc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Nanocalorie = new("nanocalorie", "nc", Microcalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picocalorie defined such that: nanocalorie = pc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Picocalorie = new("picocalorie", "pc", Nanocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtocalorie defined such that: picocalorie = fc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Femtocalorie = new("femtocalorie", "fc", Picocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attocalorie defined such that: femtocalorie = ac × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Attocalorie = new("attocalorie", "ac", Femtocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptocalorie defined such that: attocalorie = zc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Zeptocalorie = new("zeptocalorie", "zc", Attocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctocalorie defined such that: zeptocalorie = yc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Yoctocalorie = new("yoctocalorie", "yc", Zeptocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontocalorie defined such that: yoctocalorie = rc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Rontocalorie = new("rontocalorie", "rc", Yoctocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectocalorie defined such that: rontocalorie = qc × 1.0/1000.0.
   /// </summary>
   public static readonly Energy Quectocalorie = new("quectocalorie", "qc", Rontocalorie, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekacalorie defined such that: calorie = dac × 10.0.
   /// </summary>
   public static readonly Energy Dekacalorie = new("dekacalorie", "dac", Calorie, 10.0, system: "SI");
   
   /// <summary>
   /// hectocalorie defined such that: dekacalorie = hc × 10.0.
   /// </summary>
   public static readonly Energy Hectocalorie = new("hectocalorie", "hc", Dekacalorie, 10.0, system: "SI");
   
   /// <summary>
   /// kilocalorie defined such that: hectocalorie = kc × 10.0.
   /// </summary>
   public static readonly Energy Kilocalorie = new("kilocalorie", "kc", Hectocalorie, 10.0, system: "SI");
   
   /// <summary>
   /// megacalorie defined such that: kilocalorie = Mc × 1000.0.
   /// </summary>
   public static readonly Energy Megacalorie = new("megacalorie", "Mc", Kilocalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// gigacalorie defined such that: megacalorie = Gc × 1000.0.
   /// </summary>
   public static readonly Energy Gigacalorie = new("gigacalorie", "Gc", Megacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// teracalorie defined such that: gigacalorie = Tc × 1000.0.
   /// </summary>
   public static readonly Energy Teracalorie = new("teracalorie", "Tc", Gigacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// petacalorie defined such that: teracalorie = Pc × 1000.0.
   /// </summary>
   public static readonly Energy Petacalorie = new("petacalorie", "Pc", Teracalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// exacalorie defined such that: petacalorie = Ec × 1000.0.
   /// </summary>
   public static readonly Energy Exacalorie = new("exacalorie", "Ec", Petacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// zettacalorie defined such that: exacalorie = Zc × 1000.0.
   /// </summary>
   public static readonly Energy Zettacalorie = new("zettacalorie", "Zc", Exacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// yottacalorie defined such that: zettacalorie = Yc × 1000.0.
   /// </summary>
   public static readonly Energy Yottacalorie = new("yottacalorie", "Yc", Zettacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnacalorie defined such that: yottacalorie = Rc × 1000.0.
   /// </summary>
   public static readonly Energy Ronnacalorie = new("ronnacalorie", "Rc", Yottacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// quettacalorie defined such that: ronnacalorie = Qc × 1000.0.
   /// </summary>
   public static readonly Energy Quettacalorie = new("quettacalorie", "Qc", Ronnacalorie, 1000.0, system: "SI");
   
   /// <summary>
   /// Calorie (Food) defined such that: calorie = C × 1000.0.
   /// </summary>
   public static readonly Energy CalorieFood = new("Calorie (Food)", "C", Calorie, 1000.0, system: "SI");
}