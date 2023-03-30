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
   public static readonly RadiationEquivalentDose Sievert = new ("sievert", "sv");

   /// <summary>
   /// decisievert, defined as: sievert × 1.0/10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Decisievert = new ("decisievert", "dsv", Sievert, 1.0 / 10.0);

   /// <summary>
   /// centisievert, defined as: decisievert × 1.0/10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Centisievert = new ("centisievert", "csv", Decisievert, 1.0 / 10.0);

   /// <summary>
   /// millisievert, defined as: centisievert × 1.0/10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Millisievert = new ("millisievert", "msv", Centisievert, 1.0 / 10.0);

   /// <summary>
   /// microsievert, defined as: millisievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose
            Microsievert = new ("microsievert", "μsv", Millisievert, 1.0 / 1000.0);

   /// <summary>
   /// nanosievert, defined as: microsievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Nanosievert = new ("nanosievert", "nsv", Microsievert, 1.0 / 1000.0);

   /// <summary>
   /// picosievert, defined as: nanosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Picosievert = new ("picosievert", "psv", Nanosievert, 1.0 / 1000.0);

   /// <summary>
   /// femtosievert, defined as: picosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Femtosievert = new ("femtosievert", "fsv", Picosievert, 1.0 / 1000.0);

   /// <summary>
   /// attosievert, defined as: femtosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Attosievert = new ("attosievert", "asv", Femtosievert, 1.0 / 1000.0);

   /// <summary>
   /// zeptosievert, defined as: attosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Zeptosievert = new ("zeptosievert", "zsv", Attosievert, 1.0 / 1000.0);

   /// <summary>
   /// yoctosievert, defined as: zeptosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose
            Yoctosievert = new ("yoctosievert", "ysv", Zeptosievert, 1.0 / 1000.0);

   /// <summary>
   /// rontosievert, defined as: yoctosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose
            Rontosievert = new ("rontosievert", "rsv", Yoctosievert, 1.0 / 1000.0);

   /// <summary>
   /// quectosievert, defined as: rontosievert × 1.0/1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Quectosievert =
            new ("quectosievert", "qsv", Rontosievert, 1.0 / 1000.0);

   /// <summary>
   /// dekasievert, defined as: sievert × 10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Dekasievert = new ("dekasievert", "dasv", Sievert, 10.0);

   /// <summary>
   /// hectosievert, defined as: dekasievert × 10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Hectosievert = new ("hectosievert", "hsv", Dekasievert, 10.0);

   /// <summary>
   /// kilosievert, defined as: hectosievert × 10.0
   /// </summary>
   public static readonly RadiationEquivalentDose Kilosievert = new ("kilosievert", "ksv", Hectosievert, 10.0);

   /// <summary>
   /// megasievert, defined as: kilosievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Megasievert = new ("megasievert", "Msv", Kilosievert, 1000.0);

   /// <summary>
   /// gigasievert, defined as: megasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Gigasievert = new ("gigasievert", "Gsv", Megasievert, 1000.0);

   /// <summary>
   /// terasievert, defined as: gigasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Terasievert = new ("terasievert", "Tsv", Gigasievert, 1000.0);

   /// <summary>
   /// petasievert, defined as: terasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Petasievert = new ("petasievert", "Psv", Terasievert, 1000.0);

   /// <summary>
   /// exasievert, defined as: petasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Exasievert = new ("exasievert", "Esv", Petasievert, 1000.0);

   /// <summary>
   /// zettasievert, defined as: exasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Zettasievert = new ("zettasievert", "Zsv", Exasievert, 1000.0);

   /// <summary>
   /// yottasievert, defined as: zettasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Yottasievert = new ("yottasievert", "Ysv", Zettasievert, 1000.0);

   /// <summary>
   /// ronnasievert, defined as: yottasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Ronnasievert = new ("ronnasievert", "Rsv", Yottasievert, 1000.0);

   /// <summary>
   /// quettasievert, defined as: ronnasievert × 1000.0
   /// </summary>
   public static readonly RadiationEquivalentDose Quettasievert = new ("quettasievert", "Qsv", Ronnasievert, 1000.0);
}
