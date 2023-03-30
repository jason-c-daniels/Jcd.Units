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
   /// A(n) sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Sievert = new ("sievert", "sv");

   /// <summary>
   /// A(n) decisievert. Defined as: 1.0/10.0 × sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Decisievert = new ("decisievert", "dsv", Sievert, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centisievert. Defined as: 1.0/10.0 × decisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose
            Centisievert = new ("centisievert", "csv", Decisievert, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millisievert. Defined as: 1.0/10.0 × centisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Millisievert = new (
                                                                      "millisievert"
                                                                    , "msv"
                                                                    , Centisievert
                                                                    , 1.0 / 10.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) microsievert. Defined as: 1.0/1000.0 × millisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Microsievert = new (
                                                                      "microsievert"
                                                                    , "μsv"
                                                                    , Millisievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanosievert. Defined as: 1.0/1000.0 × microsievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Nanosievert = new (
                                                                     "nanosievert"
                                                                   , "nsv"
                                                                   , Microsievert
                                                                   , 1.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picosievert. Defined as: 1.0/1000.0 × nanosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose
            Picosievert = new ("picosievert", "psv", Nanosievert, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtosievert. Defined as: 1.0/1000.0 × picosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Femtosievert = new (
                                                                      "femtosievert"
                                                                    , "fsv"
                                                                    , Picosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attosievert. Defined as: 1.0/1000.0 × femtosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Attosievert = new (
                                                                     "attosievert"
                                                                   , "asv"
                                                                   , Femtosievert
                                                                   , 1.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptosievert. Defined as: 1.0/1000.0 × attosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Zeptosievert = new (
                                                                      "zeptosievert"
                                                                    , "zsv"
                                                                    , Attosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctosievert. Defined as: 1.0/1000.0 × zeptosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Yoctosievert = new (
                                                                      "yoctosievert"
                                                                    , "ysv"
                                                                    , Zeptosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rontosievert. Defined as: 1.0/1000.0 × yoctosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Rontosievert = new (
                                                                      "rontosievert"
                                                                    , "rsv"
                                                                    , Yoctosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quectosievert. Defined as: 1.0/1000.0 × rontosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Quectosievert =
            new ("quectosievert", "qsv", Rontosievert, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekasievert. Defined as: 10.0 × sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Dekasievert = new ("dekasievert", "dasv", Sievert, 10.0, 0);

   /// <summary>
   /// A(n) hectosievert. Defined as: 10.0 × dekasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Hectosievert = new ("hectosievert", "hsv", Dekasievert, 10.0, 0);

   /// <summary>
   /// A(n) kilosievert. Defined as: 10.0 × hectosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Kilosievert = new ("kilosievert", "ksv", Hectosievert, 10.0, 0);

   /// <summary>
   /// A(n) megasievert. Defined as: 1000.0 × kilosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Megasievert = new ("megasievert", "Msv", Kilosievert, 1000.0, 0);

   /// <summary>
   /// A(n) gigasievert. Defined as: 1000.0 × megasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Gigasievert = new ("gigasievert", "Gsv", Megasievert, 1000.0, 0);

   /// <summary>
   /// A(n) terasievert. Defined as: 1000.0 × gigasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Terasievert = new ("terasievert", "Tsv", Gigasievert, 1000.0, 0);

   /// <summary>
   /// A(n) petasievert. Defined as: 1000.0 × terasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Petasievert = new ("petasievert", "Psv", Terasievert, 1000.0, 0);

   /// <summary>
   /// A(n) exasievert. Defined as: 1000.0 × petasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Exasievert = new ("exasievert", "Esv", Petasievert, 1000.0, 0);

   /// <summary>
   /// A(n) zettasievert. Defined as: 1000.0 × exasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Zettasievert = new ("zettasievert", "Zsv", Exasievert, 1000.0, 0);

   /// <summary>
   /// A(n) yottasievert. Defined as: 1000.0 × zettasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Yottasievert = new ("yottasievert", "Ysv", Zettasievert, 1000.0, 0);

   /// <summary>
   /// A(n) ronnasievert. Defined as: 1000.0 × yottasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Ronnasievert = new ("ronnasievert", "Rsv", Yottasievert, 1000.0, 0);

   /// <summary>
   /// A(n) quettasievert. Defined as: 1000.0 × ronnasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Quettasievert = new ("quettasievert", "Qsv", Ronnasievert, 1000.0, 0);
}
