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
/// International System of Units for measuring Electrical Conductance.
/// </summary>
public class ElectricalConductances : UnitOfMeasureEnumeration<ElectricalConductances, ElectricalConductance>
{
   /// <summary>
   /// A(n) siemens.
   /// </summary>
   public static readonly ElectricalConductance Siemens = new ("siemens", "S");

   /// <summary>
   /// A(n) decisiemens. Defined as: 1.0/10.0 × siemens.
   /// </summary>
   public static readonly ElectricalConductance Decisiemens = new ("decisiemens", "dS", Siemens, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centisiemens. Defined as: 1.0/10.0 × decisiemens.
   /// </summary>
   public static readonly ElectricalConductance Centisiemens = new ("centisiemens", "cS", Decisiemens, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millisiemens. Defined as: 1.0/10.0 × centisiemens.
   /// </summary>
   public static readonly ElectricalConductance Millisiemens = new ("millisiemens", "mS", Centisiemens, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microsiemens. Defined as: 1.0/1000.0 × millisiemens.
   /// </summary>
   public static readonly ElectricalConductance
            Microsiemens = new ("microsiemens", "μS", Millisiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanosiemens. Defined as: 1.0/1000.0 × microsiemens.
   /// </summary>
   public static readonly ElectricalConductance Nanosiemens = new ("nanosiemens", "nS", Microsiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picosiemens. Defined as: 1.0/1000.0 × nanosiemens.
   /// </summary>
   public static readonly ElectricalConductance Picosiemens = new ("picosiemens", "pS", Nanosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtosiemens. Defined as: 1.0/1000.0 × picosiemens.
   /// </summary>
   public static readonly ElectricalConductance Femtosiemens = new ("femtosiemens", "fS", Picosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attosiemens. Defined as: 1.0/1000.0 × femtosiemens.
   /// </summary>
   public static readonly ElectricalConductance Attosiemens = new ("attosiemens", "aS", Femtosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptosiemens. Defined as: 1.0/1000.0 × attosiemens.
   /// </summary>
   public static readonly ElectricalConductance Zeptosiemens = new ("zeptosiemens", "zS", Attosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctosiemens. Defined as: 1.0/1000.0 × zeptosiemens.
   /// </summary>
   public static readonly ElectricalConductance
            Yoctosiemens = new ("yoctosiemens", "yS", Zeptosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontosiemens. Defined as: 1.0/1000.0 × yoctosiemens.
   /// </summary>
   public static readonly ElectricalConductance
            Rontosiemens = new ("rontosiemens", "rS", Yoctosiemens, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectosiemens. Defined as: 1.0/1000.0 × rontosiemens.
   /// </summary>
   public static readonly ElectricalConductance Quectosiemens = new (
                                                                     "quectosiemens"
                                                                   , "qS"
                                                                   , Rontosiemens
                                                                   , 1.0 / 1000.0
                                                                   , 0
                                                                    );

   /// <summary>
   /// A(n) dekasiemens. Defined as: 10.0 × siemens.
   /// </summary>
   public static readonly ElectricalConductance Dekasiemens = new ("dekasiemens", "daS", Siemens, 10.0, 0);

   /// <summary>
   /// A(n) hectosiemens. Defined as: 10.0 × dekasiemens.
   /// </summary>
   public static readonly ElectricalConductance Hectosiemens = new ("hectosiemens", "hS", Dekasiemens, 10.0, 0);

   /// <summary>
   /// A(n) kilosiemens. Defined as: 10.0 × hectosiemens.
   /// </summary>
   public static readonly ElectricalConductance Kilosiemens = new ("kilosiemens", "kS", Hectosiemens, 10.0, 0);

   /// <summary>
   /// A(n) megasiemens. Defined as: 1000.0 × kilosiemens.
   /// </summary>
   public static readonly ElectricalConductance Megasiemens = new ("megasiemens", "MS", Kilosiemens, 1000.0, 0);

   /// <summary>
   /// A(n) gigasiemens. Defined as: 1000.0 × megasiemens.
   /// </summary>
   public static readonly ElectricalConductance Gigasiemens = new ("gigasiemens", "GS", Megasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) terasiemens. Defined as: 1000.0 × gigasiemens.
   /// </summary>
   public static readonly ElectricalConductance Terasiemens = new ("terasiemens", "TS", Gigasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) petasiemens. Defined as: 1000.0 × terasiemens.
   /// </summary>
   public static readonly ElectricalConductance Petasiemens = new ("petasiemens", "PS", Terasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) exasiemens. Defined as: 1000.0 × petasiemens.
   /// </summary>
   public static readonly ElectricalConductance Exasiemens = new ("exasiemens", "ES", Petasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) zettasiemens. Defined as: 1000.0 × exasiemens.
   /// </summary>
   public static readonly ElectricalConductance Zettasiemens = new ("zettasiemens", "ZS", Exasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) yottasiemens. Defined as: 1000.0 × zettasiemens.
   /// </summary>
   public static readonly ElectricalConductance Yottasiemens = new ("yottasiemens", "YS", Zettasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) ronnasiemens. Defined as: 1000.0 × yottasiemens.
   /// </summary>
   public static readonly ElectricalConductance Ronnasiemens = new ("ronnasiemens", "RS", Yottasiemens, 1000.0, 0);

   /// <summary>
   /// A(n) quettasiemens. Defined as: 1000.0 × ronnasiemens.
   /// </summary>
   public static readonly ElectricalConductance Quettasiemens = new ("quettasiemens", "QS", Ronnasiemens, 1000.0, 0);
}
