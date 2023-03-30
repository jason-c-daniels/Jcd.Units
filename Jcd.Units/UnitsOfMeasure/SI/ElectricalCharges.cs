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
   /// A(n) decicoulomb. Defined as: 1.0/10.0 × coulomb.
   /// </summary>
   public static readonly ElectricalCharge Decicoulomb = new ("decicoulomb", "dC", Coulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centicoulomb. Defined as: 1.0/10.0 × decicoulomb.
   /// </summary>
   public static readonly ElectricalCharge Centicoulomb = new ("centicoulomb", "cC", Decicoulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millicoulomb. Defined as: 1.0/10.0 × centicoulomb.
   /// </summary>
   public static readonly ElectricalCharge Millicoulomb = new ("millicoulomb", "mC", Centicoulomb, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microcoulomb. Defined as: 1.0/1000.0 × millicoulomb.
   /// </summary>
   public static readonly ElectricalCharge Microcoulomb = new ("microcoulomb", "μC", Millicoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanocoulomb. Defined as: 1.0/1000.0 × microcoulomb.
   /// </summary>
   public static readonly ElectricalCharge Nanocoulomb = new ("nanocoulomb", "nC", Microcoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picocoulomb. Defined as: 1.0/1000.0 × nanocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Picocoulomb = new ("picocoulomb", "pC", Nanocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtocoulomb. Defined as: 1.0/1000.0 × picocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Femtocoulomb = new ("femtocoulomb", "fC", Picocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attocoulomb. Defined as: 1.0/1000.0 × femtocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Attocoulomb = new ("attocoulomb", "aC", Femtocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptocoulomb. Defined as: 1.0/1000.0 × attocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Zeptocoulomb = new ("zeptocoulomb", "zC", Attocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctocoulomb. Defined as: 1.0/1000.0 × zeptocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Yoctocoulomb = new ("yoctocoulomb", "yC", Zeptocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontocoulomb. Defined as: 1.0/1000.0 × yoctocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Rontocoulomb = new ("rontocoulomb", "rC", Yoctocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectocoulomb. Defined as: 1.0/1000.0 × rontocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Quectocoulomb = new ("quectocoulomb", "qC", Rontocoulomb, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekacoulomb. Defined as: 10.0 × coulomb.
   /// </summary>
   public static readonly ElectricalCharge Dekacoulomb = new ("dekacoulomb", "daC", Coulomb, 10.0, 0);

   /// <summary>
   /// A(n) hectocoulomb. Defined as: 10.0 × dekacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Hectocoulomb = new ("hectocoulomb", "hC", Dekacoulomb, 10.0, 0);

   /// <summary>
   /// A(n) kilocoulomb. Defined as: 10.0 × hectocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Kilocoulomb = new ("kilocoulomb", "kC", Hectocoulomb, 10.0, 0);

   /// <summary>
   /// A(n) megacoulomb. Defined as: 1000.0 × kilocoulomb.
   /// </summary>
   public static readonly ElectricalCharge Megacoulomb = new ("megacoulomb", "MC", Kilocoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) gigacoulomb. Defined as: 1000.0 × megacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Gigacoulomb = new ("gigacoulomb", "GC", Megacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) teracoulomb. Defined as: 1000.0 × gigacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Teracoulomb = new ("teracoulomb", "TC", Gigacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) petacoulomb. Defined as: 1000.0 × teracoulomb.
   /// </summary>
   public static readonly ElectricalCharge Petacoulomb = new ("petacoulomb", "PC", Teracoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) exacoulomb. Defined as: 1000.0 × petacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Exacoulomb = new ("exacoulomb", "EC", Petacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) zettacoulomb. Defined as: 1000.0 × exacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Zettacoulomb = new ("zettacoulomb", "ZC", Exacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) yottacoulomb. Defined as: 1000.0 × zettacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Yottacoulomb = new ("yottacoulomb", "YC", Zettacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) ronnacoulomb. Defined as: 1000.0 × yottacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Ronnacoulomb = new ("ronnacoulomb", "RC", Yottacoulomb, 1000.0, 0);

   /// <summary>
   /// A(n) quettacoulomb. Defined as: 1000.0 × ronnacoulomb.
   /// </summary>
   public static readonly ElectricalCharge Quettacoulomb = new ("quettacoulomb", "QC", Ronnacoulomb, 1000.0, 0);
}
