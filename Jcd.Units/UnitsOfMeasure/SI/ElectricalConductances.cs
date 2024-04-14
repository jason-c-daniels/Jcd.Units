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
   public static readonly ElectricalConductance Siemens = new("siemens", "S", system: "SI");
   
   /// <summary>
   /// decisiemens defined such that: siemens = dS × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalConductance Decisiemens = new("decisiemens", "dS", Siemens, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centisiemens defined such that: decisiemens = cS × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalConductance Centisiemens = new("centisiemens", "cS", Decisiemens, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millisiemens defined such that: centisiemens = mS × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalConductance Millisiemens = new("millisiemens", "mS", Centisiemens, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microsiemens defined such that: millisiemens = μS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Microsiemens = new("microsiemens", "μS", Millisiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanosiemens defined such that: microsiemens = nS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Nanosiemens = new("nanosiemens", "nS", Microsiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picosiemens defined such that: nanosiemens = pS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Picosiemens = new("picosiemens", "pS", Nanosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtosiemens defined such that: picosiemens = fS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Femtosiemens = new("femtosiemens", "fS", Picosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attosiemens defined such that: femtosiemens = aS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Attosiemens = new("attosiemens", "aS", Femtosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptosiemens defined such that: attosiemens = zS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Zeptosiemens = new("zeptosiemens", "zS", Attosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctosiemens defined such that: zeptosiemens = yS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Yoctosiemens = new("yoctosiemens", "yS", Zeptosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontosiemens defined such that: yoctosiemens = rS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Rontosiemens = new("rontosiemens", "rS", Yoctosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectosiemens defined such that: rontosiemens = qS × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalConductance Quectosiemens = new("quectosiemens", "qS", Rontosiemens, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekasiemens defined such that: siemens = daS × 10.0.
   /// </summary>
   public static readonly ElectricalConductance Dekasiemens = new("dekasiemens", "daS", Siemens, 10.0, system: "SI");
   
   /// <summary>
   /// hectosiemens defined such that: dekasiemens = hS × 10.0.
   /// </summary>
   public static readonly ElectricalConductance Hectosiemens = new("hectosiemens", "hS", Dekasiemens, 10.0, system: "SI");
   
   /// <summary>
   /// kilosiemens defined such that: hectosiemens = kS × 10.0.
   /// </summary>
   public static readonly ElectricalConductance Kilosiemens = new("kilosiemens", "kS", Hectosiemens, 10.0, system: "SI");
   
   /// <summary>
   /// megasiemens defined such that: kilosiemens = MS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Megasiemens = new("megasiemens", "MS", Kilosiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// gigasiemens defined such that: megasiemens = GS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Gigasiemens = new("gigasiemens", "GS", Megasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// terasiemens defined such that: gigasiemens = TS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Terasiemens = new("terasiemens", "TS", Gigasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// petasiemens defined such that: terasiemens = PS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Petasiemens = new("petasiemens", "PS", Terasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// exasiemens defined such that: petasiemens = ES × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Exasiemens = new("exasiemens", "ES", Petasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// zettasiemens defined such that: exasiemens = ZS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Zettasiemens = new("zettasiemens", "ZS", Exasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// yottasiemens defined such that: zettasiemens = YS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Yottasiemens = new("yottasiemens", "YS", Zettasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnasiemens defined such that: yottasiemens = RS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Ronnasiemens = new("ronnasiemens", "RS", Yottasiemens, 1000.0, system: "SI");
   
   /// <summary>
   /// quettasiemens defined such that: ronnasiemens = QS × 1000.0.
   /// </summary>
   public static readonly ElectricalConductance Quettasiemens = new("quettasiemens", "QS", Ronnasiemens, 1000.0, system: "SI");
}