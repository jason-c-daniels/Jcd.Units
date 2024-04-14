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
/// International System of Units for measuring Radiation Equivalent Dose.
/// </summary>
public class RadiationEquivalentDoses : UnitOfMeasureEnumeration<RadiationEquivalentDoses, RadiationEquivalentDose>
{
   /// <summary>
   /// sievert, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly RadiationEquivalentDose Sievert = new("sievert", "sv", system: "SI");
   
   /// <summary>
   /// decisievert defined such that: sievert = dsv × 1.0/10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Decisievert = new("decisievert", "dsv", Sievert, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centisievert defined such that: decisievert = csv × 1.0/10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Centisievert = new("centisievert", "csv", Decisievert, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millisievert defined such that: centisievert = msv × 1.0/10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Millisievert = new("millisievert", "msv", Centisievert, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microsievert defined such that: millisievert = μsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Microsievert = new("microsievert", "μsv", Millisievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanosievert defined such that: microsievert = nsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Nanosievert = new("nanosievert", "nsv", Microsievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picosievert defined such that: nanosievert = psv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Picosievert = new("picosievert", "psv", Nanosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtosievert defined such that: picosievert = fsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Femtosievert = new("femtosievert", "fsv", Picosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attosievert defined such that: femtosievert = asv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Attosievert = new("attosievert", "asv", Femtosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptosievert defined such that: attosievert = zsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Zeptosievert = new("zeptosievert", "zsv", Attosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctosievert defined such that: zeptosievert = ysv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Yoctosievert = new("yoctosievert", "ysv", Zeptosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontosievert defined such that: yoctosievert = rsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Rontosievert = new("rontosievert", "rsv", Yoctosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectosievert defined such that: rontosievert = qsv × 1.0/1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Quectosievert = new("quectosievert", "qsv", Rontosievert, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekasievert defined such that: sievert = dasv × 10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Dekasievert = new("dekasievert", "dasv", Sievert, 10.0, system: "SI");
   
   /// <summary>
   /// hectosievert defined such that: dekasievert = hsv × 10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Hectosievert = new("hectosievert", "hsv", Dekasievert, 10.0, system: "SI");
   
   /// <summary>
   /// kilosievert defined such that: hectosievert = ksv × 10.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Kilosievert = new("kilosievert", "ksv", Hectosievert, 10.0, system: "SI");
   
   /// <summary>
   /// megasievert defined such that: kilosievert = Msv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Megasievert = new("megasievert", "Msv", Kilosievert, 1000.0, system: "SI");
   
   /// <summary>
   /// gigasievert defined such that: megasievert = Gsv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Gigasievert = new("gigasievert", "Gsv", Megasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// terasievert defined such that: gigasievert = Tsv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Terasievert = new("terasievert", "Tsv", Gigasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// petasievert defined such that: terasievert = Psv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Petasievert = new("petasievert", "Psv", Terasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// exasievert defined such that: petasievert = Esv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Exasievert = new("exasievert", "Esv", Petasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// zettasievert defined such that: exasievert = Zsv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Zettasievert = new("zettasievert", "Zsv", Exasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// yottasievert defined such that: zettasievert = Ysv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Yottasievert = new("yottasievert", "Ysv", Zettasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnasievert defined such that: yottasievert = Rsv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Ronnasievert = new("ronnasievert", "Rsv", Yottasievert, 1000.0, system: "SI");
   
   /// <summary>
   /// quettasievert defined such that: ronnasievert = Qsv × 1000.0.
   /// </summary>
   public static readonly RadiationEquivalentDose Quettasievert = new("quettasievert", "Qsv", Ronnasievert, 1000.0, system: "SI");
}