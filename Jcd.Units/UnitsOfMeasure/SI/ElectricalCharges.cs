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
   /// A(n) coulomb.
   /// </summary>
   public static readonly ElectricalCharge Coulomb = new ("coulomb", "C");

   /// <summary>
   /// A(n) decicoulomb. Defined as: (1.0/10.0) × coulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Decicoulomb = new ("decicoulomb", "dC", Coulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centicoulomb. Defined as: (1.0/10.0) × decicoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Centicoulomb = new ("centicoulomb", "cC", Decicoulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millicoulomb. Defined as: (1.0/10.0) × centicoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Millicoulomb = new ("millicoulomb", "mC", Centicoulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microcoulomb. Defined as: (1.0/1000.0) × millicoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Microcoulomb = new ("microcoulomb", "μC", Millicoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanocoulomb. Defined as: (1.0/1000.0) × microcoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Nanocoulomb = new ("nanocoulomb", "nC", Microcoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picocoulomb. Defined as: (1.0/1000.0) × nanocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Picocoulomb = new ("picocoulomb", "pC", Nanocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtocoulomb. Defined as: (1.0/1000.0) × picocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Femtocoulomb = new ("femtocoulomb", "fC", Picocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attocoulomb. Defined as: (1.0/1000.0) × femtocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Attocoulomb = new ("attocoulomb", "aC", Femtocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptocoulomb. Defined as: (1.0/1000.0) × attocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Zeptocoulomb = new ("zeptocoulomb", "zC", Attocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctocoulomb. Defined as: (1.0/1000.0) × zeptocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Yoctocoulomb = new ("yoctocoulomb", "yC", Zeptocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontocoulomb. Defined as: (1.0/1000.0) × yoctocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Rontocoulomb = new ("rontocoulomb", "rC", Yoctocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectocoulomb. Defined as: (1.0/1000.0) × rontocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Quectocoulomb = new ("quectocoulomb", "qC", Rontocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekacoulomb. Defined as: (10.0) × coulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Dekacoulomb = new ("dekacoulomb", "daC", Coulomb, 10.0, 0);

   /// <summary>
   /// A(n) hectocoulomb. Defined as: (10.0) × dekacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Hectocoulomb = new ("hectocoulomb", "hC", Dekacoulomb, 10.0, 0);

   /// <summary>
   /// A(n) kilocoulomb. Defined as: (10.0) × hectocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Kilocoulomb = new ("kilocoulomb", "kC", Hectocoulomb, 10.0, 0);

   /// <summary>
   /// A(n) megacoulomb. Defined as: (1000.0) × kilocoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Megacoulomb = new ("megacoulomb", "MC", Kilocoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) gigacoulomb. Defined as: (1000.0) × megacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Gigacoulomb = new ("gigacoulomb", "GC", Megacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) teracoulomb. Defined as: (1000.0) × gigacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Teracoulomb = new ("teracoulomb", "TC", Gigacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) petacoulomb. Defined as: (1000.0) × teracoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Petacoulomb = new ("petacoulomb", "PC", Teracoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) exacoulomb. Defined as: (1000.0) × petacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Exacoulomb = new ("exacoulomb", "EC", Petacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) zettacoulomb. Defined as: (1000.0) × exacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Zettacoulomb = new ("zettacoulomb", "ZC", Exacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) yottacoulomb. Defined as: (1000.0) × zettacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Yottacoulomb = new ("yottacoulomb", "YC", Zettacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) ronnacoulomb. Defined as: (1000.0) × yottacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Ronnacoulomb = new ("ronnacoulomb", "RC", Yottacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) quettacoulomb. Defined as: (1000.0) × ronnacoulomb + (0).
   /// </summary>
   public static readonly ElectricalCharge Quettacoulomb = new ("quettacoulomb", "QC", Ronnacoulomb, 1000.0, 0);
}
