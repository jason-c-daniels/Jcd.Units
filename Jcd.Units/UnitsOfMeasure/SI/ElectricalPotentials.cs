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
/// International System of Units for measuring Electrical Potential.
/// </summary>
public class ElectricalPotentials : UnitOfMeasureEnumeration<ElectricalPotentials, ElectricalPotential>
{
   /// <summary>
   /// A(n) volt.
   /// </summary>
   public static readonly ElectricalPotential Volt = new ("volt", "V");

   /// <summary>
   /// A(n) decivolt. Defined as: 1.0/10.0 × volt.
   /// </summary>
   public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centivolt. Defined as: 1.0/10.0 × decivolt.
   /// </summary>
   public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millivolt. Defined as: 1.0/10.0 × centivolt.
   /// </summary>
   public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microvolt. Defined as: 1.0/1000.0 × millivolt.
   /// </summary>
   public static readonly ElectricalPotential Microvolt = new ("microvolt", "μV", Millivolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanovolt. Defined as: 1.0/1000.0 × microvolt.
   /// </summary>
   public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picovolt. Defined as: 1.0/1000.0 × nanovolt.
   /// </summary>
   public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtovolt. Defined as: 1.0/1000.0 × picovolt.
   /// </summary>
   public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attovolt. Defined as: 1.0/1000.0 × femtovolt.
   /// </summary>
   public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptovolt. Defined as: 1.0/1000.0 × attovolt.
   /// </summary>
   public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctovolt. Defined as: 1.0/1000.0 × zeptovolt.
   /// </summary>
   public static readonly ElectricalPotential Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontovolt. Defined as: 1.0/1000.0 × yoctovolt.
   /// </summary>
   public static readonly ElectricalPotential Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectovolt. Defined as: 1.0/1000.0 × rontovolt.
   /// </summary>
   public static readonly ElectricalPotential Quectovolt = new ("quectovolt", "qV", Rontovolt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekavolt. Defined as: 10.0 × volt.
   /// </summary>
   public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10.0, 0);

   /// <summary>
   /// A(n) hectovolt. Defined as: 10.0 × dekavolt.
   /// </summary>
   public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10.0, 0);

   /// <summary>
   /// A(n) kilovolt. Defined as: 10.0 × hectovolt.
   /// </summary>
   public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10.0, 0);

   /// <summary>
   /// A(n) megavolt. Defined as: 1000.0 × kilovolt.
   /// </summary>
   public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000.0, 0);

   /// <summary>
   /// A(n) gigavolt. Defined as: 1000.0 × megavolt.
   /// </summary>
   public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000.0, 0);

   /// <summary>
   /// A(n) teravolt. Defined as: 1000.0 × gigavolt.
   /// </summary>
   public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000.0, 0);

   /// <summary>
   /// A(n) petavolt. Defined as: 1000.0 × teravolt.
   /// </summary>
   public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000.0, 0);

   /// <summary>
   /// A(n) exavolt. Defined as: 1000.0 × petavolt.
   /// </summary>
   public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000.0, 0);

   /// <summary>
   /// A(n) zettavolt. Defined as: 1000.0 × exavolt.
   /// </summary>
   public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000.0, 0);

   /// <summary>
   /// A(n) yottavolt. Defined as: 1000.0 × zettavolt.
   /// </summary>
   public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000.0, 0);

   /// <summary>
   /// A(n) ronnavolt. Defined as: 1000.0 × yottavolt.
   /// </summary>
   public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000.0, 0);

   /// <summary>
   /// A(n) quettavolt. Defined as: 1000.0 × ronnavolt.
   /// </summary>
   public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000.0, 0);
}
