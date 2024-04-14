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
/// International System of Units for measuring Electrical Charge.
/// </summary>
public class ElectricalCharges : UnitOfMeasureEnumeration<ElectricalCharges, ElectricalCharge>
{
   /// <summary>
   /// coulomb, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly ElectricalCharge Coulomb = new("coulomb", "C", system: "SI");
   
   /// <summary>
   /// decicoulomb defined such that: coulomb = dC × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalCharge Decicoulomb = new("decicoulomb", "dC", Coulomb, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centicoulomb defined such that: decicoulomb = cC × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalCharge Centicoulomb = new("centicoulomb", "cC", Decicoulomb, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millicoulomb defined such that: centicoulomb = mC × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalCharge Millicoulomb = new("millicoulomb", "mC", Centicoulomb, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microcoulomb defined such that: millicoulomb = μC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Microcoulomb = new("microcoulomb", "μC", Millicoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanocoulomb defined such that: microcoulomb = nC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Nanocoulomb = new("nanocoulomb", "nC", Microcoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picocoulomb defined such that: nanocoulomb = pC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Picocoulomb = new("picocoulomb", "pC", Nanocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtocoulomb defined such that: picocoulomb = fC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Femtocoulomb = new("femtocoulomb", "fC", Picocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attocoulomb defined such that: femtocoulomb = aC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Attocoulomb = new("attocoulomb", "aC", Femtocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptocoulomb defined such that: attocoulomb = zC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Zeptocoulomb = new("zeptocoulomb", "zC", Attocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctocoulomb defined such that: zeptocoulomb = yC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Yoctocoulomb = new("yoctocoulomb", "yC", Zeptocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontocoulomb defined such that: yoctocoulomb = rC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Rontocoulomb = new("rontocoulomb", "rC", Yoctocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectocoulomb defined such that: rontocoulomb = qC × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalCharge Quectocoulomb = new("quectocoulomb", "qC", Rontocoulomb, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekacoulomb defined such that: coulomb = daC × 10.0.
   /// </summary>
   public static readonly ElectricalCharge Dekacoulomb = new("dekacoulomb", "daC", Coulomb, 10.0, system: "SI");
   
   /// <summary>
   /// hectocoulomb defined such that: dekacoulomb = hC × 10.0.
   /// </summary>
   public static readonly ElectricalCharge Hectocoulomb = new("hectocoulomb", "hC", Dekacoulomb, 10.0, system: "SI");
   
   /// <summary>
   /// kilocoulomb defined such that: hectocoulomb = kC × 10.0.
   /// </summary>
   public static readonly ElectricalCharge Kilocoulomb = new("kilocoulomb", "kC", Hectocoulomb, 10.0, system: "SI");
   
   /// <summary>
   /// megacoulomb defined such that: kilocoulomb = MC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Megacoulomb = new("megacoulomb", "MC", Kilocoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// gigacoulomb defined such that: megacoulomb = GC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Gigacoulomb = new("gigacoulomb", "GC", Megacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// teracoulomb defined such that: gigacoulomb = TC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Teracoulomb = new("teracoulomb", "TC", Gigacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// petacoulomb defined such that: teracoulomb = PC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Petacoulomb = new("petacoulomb", "PC", Teracoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// exacoulomb defined such that: petacoulomb = EC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Exacoulomb = new("exacoulomb", "EC", Petacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// zettacoulomb defined such that: exacoulomb = ZC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Zettacoulomb = new("zettacoulomb", "ZC", Exacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// yottacoulomb defined such that: zettacoulomb = YC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Yottacoulomb = new("yottacoulomb", "YC", Zettacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnacoulomb defined such that: yottacoulomb = RC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Ronnacoulomb = new("ronnacoulomb", "RC", Yottacoulomb, 1000.0, system: "SI");
   
   /// <summary>
   /// quettacoulomb defined such that: ronnacoulomb = QC × 1000.0.
   /// </summary>
   public static readonly ElectricalCharge Quettacoulomb = new("quettacoulomb", "QC", Ronnacoulomb, 1000.0, system: "SI");
}