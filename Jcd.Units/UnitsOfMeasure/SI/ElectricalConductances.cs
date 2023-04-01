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
   /// siemens, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly ElectricalConductance Siemens = new ("siemens", "S", system: "SI");

   /// <summary>
   /// decisiemens, defined as: siemens × 1.0/10.0
   /// </summary>
   public static readonly ElectricalConductance Decisiemens = new (
                                                                   "decisiemens"
                                                                 , "dS"
                                                                 , Siemens
                                                                 , 1.0 / 10.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// centisiemens, defined as: decisiemens × 1.0/10.0
   /// </summary>
   public static readonly ElectricalConductance Centisiemens = new (
                                                                    "centisiemens"
                                                                  , "cS"
                                                                  , Decisiemens
                                                                  , 1.0 / 10.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// millisiemens, defined as: centisiemens × 1.0/10.0
   /// </summary>
   public static readonly ElectricalConductance Millisiemens = new (
                                                                    "millisiemens"
                                                                  , "mS"
                                                                  , Centisiemens
                                                                  , 1.0 / 10.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// microsiemens, defined as: millisiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Microsiemens = new (
                                                                    "microsiemens"
                                                                  , "μS"
                                                                  , Millisiemens
                                                                  , 1.0 / 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// nanosiemens, defined as: microsiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Nanosiemens = new (
                                                                   "nanosiemens"
                                                                 , "nS"
                                                                 , Microsiemens
                                                                 , 1.0 / 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// picosiemens, defined as: nanosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Picosiemens = new (
                                                                   "picosiemens"
                                                                 , "pS"
                                                                 , Nanosiemens
                                                                 , 1.0 / 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// femtosiemens, defined as: picosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Femtosiemens = new (
                                                                    "femtosiemens"
                                                                  , "fS"
                                                                  , Picosiemens
                                                                  , 1.0 / 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// attosiemens, defined as: femtosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Attosiemens = new (
                                                                   "attosiemens"
                                                                 , "aS"
                                                                 , Femtosiemens
                                                                 , 1.0 / 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// zeptosiemens, defined as: attosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Zeptosiemens = new (
                                                                    "zeptosiemens"
                                                                  , "zS"
                                                                  , Attosiemens
                                                                  , 1.0 / 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// yoctosiemens, defined as: zeptosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Yoctosiemens = new (
                                                                    "yoctosiemens"
                                                                  , "yS"
                                                                  , Zeptosiemens
                                                                  , 1.0 / 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// rontosiemens, defined as: yoctosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Rontosiemens = new (
                                                                    "rontosiemens"
                                                                  , "rS"
                                                                  , Yoctosiemens
                                                                  , 1.0 / 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// quectosiemens, defined as: rontosiemens × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalConductance Quectosiemens = new (
                                                                     "quectosiemens"
                                                                   , "qS"
                                                                   , Rontosiemens
                                                                   , 1.0 / 1000.0
                                                                   , system: "SI"
                                                                    );

   /// <summary>
   /// dekasiemens, defined as: siemens × 10.0
   /// </summary>
   public static readonly ElectricalConductance Dekasiemens = new ("dekasiemens", "daS", Siemens, 10.0, system: "SI");

   /// <summary>
   /// hectosiemens, defined as: dekasiemens × 10.0
   /// </summary>
   public static readonly ElectricalConductance Hectosiemens = new (
                                                                    "hectosiemens"
                                                                  , "hS"
                                                                  , Dekasiemens
                                                                  , 10.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// kilosiemens, defined as: hectosiemens × 10.0
   /// </summary>
   public static readonly ElectricalConductance Kilosiemens = new (
                                                                   "kilosiemens"
                                                                 , "kS"
                                                                 , Hectosiemens
                                                                 , 10.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// megasiemens, defined as: kilosiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Megasiemens = new (
                                                                   "megasiemens"
                                                                 , "MS"
                                                                 , Kilosiemens
                                                                 , 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// gigasiemens, defined as: megasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Gigasiemens = new (
                                                                   "gigasiemens"
                                                                 , "GS"
                                                                 , Megasiemens
                                                                 , 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// terasiemens, defined as: gigasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Terasiemens = new (
                                                                   "terasiemens"
                                                                 , "TS"
                                                                 , Gigasiemens
                                                                 , 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// petasiemens, defined as: terasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Petasiemens = new (
                                                                   "petasiemens"
                                                                 , "PS"
                                                                 , Terasiemens
                                                                 , 1000.0
                                                                 , system: "SI"
                                                                  );

   /// <summary>
   /// exasiemens, defined as: petasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance
            Exasiemens = new ("exasiemens", "ES", Petasiemens, 1000.0, system: "SI");

   /// <summary>
   /// zettasiemens, defined as: exasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Zettasiemens = new (
                                                                    "zettasiemens"
                                                                  , "ZS"
                                                                  , Exasiemens
                                                                  , 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// yottasiemens, defined as: zettasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Yottasiemens = new (
                                                                    "yottasiemens"
                                                                  , "YS"
                                                                  , Zettasiemens
                                                                  , 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// ronnasiemens, defined as: yottasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Ronnasiemens = new (
                                                                    "ronnasiemens"
                                                                  , "RS"
                                                                  , Yottasiemens
                                                                  , 1000.0
                                                                  , system: "SI"
                                                                   );

   /// <summary>
   /// quettasiemens, defined as: ronnasiemens × 1000.0
   /// </summary>
   public static readonly ElectricalConductance Quettasiemens = new (
                                                                     "quettasiemens"
                                                                   , "QS"
                                                                   , Ronnasiemens
                                                                   , 1000.0
                                                                   , system: "SI"
                                                                    );
}
