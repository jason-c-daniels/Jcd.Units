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
   /// volt, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly ElectricalPotential Volt = new ("volt", "V", system: "SI");

   /// <summary>
   /// decivolt, defined as: volt × 1.0/10.0
   /// </summary>
   public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centivolt, defined as: decivolt × 1.0/10.0
   /// </summary>
   public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millivolt, defined as: centivolt × 1.0/10.0
   /// </summary>
   public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microvolt, defined as: millivolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential
            Microvolt = new ("microvolt", "μV", Millivolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanovolt, defined as: microvolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picovolt, defined as: nanovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtovolt, defined as: picovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attovolt, defined as: femtovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptovolt, defined as: attovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctovolt, defined as: zeptovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential
            Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontovolt, defined as: yoctovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential
            Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectovolt, defined as: rontovolt × 1.0/1000.0
   /// </summary>
   public static readonly ElectricalPotential Quectovolt = new (
                                                                "quectovolt"
                                                              , "qV"
                                                              , Rontovolt
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// dekavolt, defined as: volt × 10.0
   /// </summary>
   public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10.0, system: "SI");

   /// <summary>
   /// hectovolt, defined as: dekavolt × 10.0
   /// </summary>
   public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10.0, system: "SI");

   /// <summary>
   /// kilovolt, defined as: hectovolt × 10.0
   /// </summary>
   public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10.0, system: "SI");

   /// <summary>
   /// megavolt, defined as: kilovolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000.0, system: "SI");

   /// <summary>
   /// gigavolt, defined as: megavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000.0, system: "SI");

   /// <summary>
   /// teravolt, defined as: gigavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000.0, system: "SI");

   /// <summary>
   /// petavolt, defined as: teravolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000.0, system: "SI");

   /// <summary>
   /// exavolt, defined as: petavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000.0, system: "SI");

   /// <summary>
   /// zettavolt, defined as: exavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000.0, system: "SI");

   /// <summary>
   /// yottavolt, defined as: zettavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000.0, system: "SI");

   /// <summary>
   /// ronnavolt, defined as: yottavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000.0, system: "SI");

   /// <summary>
   /// quettavolt, defined as: ronnavolt × 1000.0
   /// </summary>
   public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000.0, system: "SI");
}
