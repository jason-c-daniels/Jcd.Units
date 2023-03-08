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
public class RadiationEquivalentDoses : Enumeration<RadiationEquivalentDoses, RadiationEquivalentDose>
{
   /// <summary>
   /// A(n) sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Sievert = new ("sievert", "sv");

   /// <summary>
   /// A(n) decisievert. Defined in terms of a(n) sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Decisievert = new ("decisievert", "dsv", Sievert, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centisievert. Defined in terms of a(n) decisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose
            Centisievert = new ("centisievert", "csv", Decisievert, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millisievert. Defined in terms of a(n) centisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Millisievert = new (
                                                                      "millisievert"
                                                                    , "msv"
                                                                    , Centisievert
                                                                    , 1.0 / 10.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) microsievert. Defined in terms of a(n) millisievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Microsievert = new (
                                                                      "microsievert"
                                                                    , "μsv"
                                                                    , Millisievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) nanosievert. Defined in terms of a(n) microsievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Nanosievert = new (
                                                                     "nanosievert"
                                                                   , "nsv"
                                                                   , Microsievert
                                                                   , 1.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) picosievert. Defined in terms of a(n) nanosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose
            Picosievert = new ("picosievert", "psv", Nanosievert, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtosievert. Defined in terms of a(n) picosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Femtosievert = new (
                                                                      "femtosievert"
                                                                    , "fsv"
                                                                    , Picosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) attosievert. Defined in terms of a(n) femtosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Attosievert = new (
                                                                     "attosievert"
                                                                   , "asv"
                                                                   , Femtosievert
                                                                   , 1.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) zeptosievert. Defined in terms of a(n) attosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Zeptosievert = new (
                                                                      "zeptosievert"
                                                                    , "zsv"
                                                                    , Attosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) yoctosievert. Defined in terms of a(n) zeptosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Yoctosievert = new (
                                                                      "yoctosievert"
                                                                    , "ysv"
                                                                    , Zeptosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) rontosievert. Defined in terms of a(n) yoctosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Rontosievert = new (
                                                                      "rontosievert"
                                                                    , "rsv"
                                                                    , Yoctosievert
                                                                    , 1.0 / 1000.0
                                                                    , 0
                                                                     );

   /// <summary>
   /// A(n) quectosievert. Defined in terms of a(n) rontosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Quectosievert =
            new ("quectosievert", "qsv", Rontosievert, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekasievert. Defined in terms of a(n) sievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Dekasievert = new ("dekasievert", "dasv", Sievert, 10, 0);

   /// <summary>
   /// A(n) hectosievert. Defined in terms of a(n) dekasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Hectosievert = new ("hectosievert", "hsv", Dekasievert, 10, 0);

   /// <summary>
   /// A(n) kilosievert. Defined in terms of a(n) hectosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Kilosievert = new ("kilosievert", "ksv", Hectosievert, 10, 0);

   /// <summary>
   /// A(n) megasievert. Defined in terms of a(n) kilosievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Megasievert = new ("megasievert", "Msv", Kilosievert, 1000, 0);

   /// <summary>
   /// A(n) gigasievert. Defined in terms of a(n) megasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Gigasievert = new ("gigasievert", "Gsv", Megasievert, 1000, 0);

   /// <summary>
   /// A(n) terasievert. Defined in terms of a(n) gigasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Terasievert = new ("terasievert", "Tsv", Gigasievert, 1000, 0);

   /// <summary>
   /// A(n) petasievert. Defined in terms of a(n) terasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Petasievert = new ("petasievert", "Psv", Terasievert, 1000, 0);

   /// <summary>
   /// A(n) exasievert. Defined in terms of a(n) petasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Exasievert = new ("exasievert", "Esv", Petasievert, 1000, 0);

   /// <summary>
   /// A(n) zettasievert. Defined in terms of a(n) exasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Zettasievert = new ("zettasievert", "Zsv", Exasievert, 1000, 0);

   /// <summary>
   /// A(n) yottasievert. Defined in terms of a(n) zettasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Yottasievert = new ("yottasievert", "Ysv", Zettasievert, 1000, 0);

   /// <summary>
   /// A(n) ronnasievert. Defined in terms of a(n) yottasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Ronnasievert = new ("ronnasievert", "Rsv", Yottasievert, 1000, 0);

   /// <summary>
   /// A(n) quettasievert. Defined in terms of a(n) ronnasievert.
   /// </summary>
   public static readonly RadiationEquivalentDose Quettasievert = new ("quettasievert", "Qsv", Ronnasievert, 1000, 0);
}
