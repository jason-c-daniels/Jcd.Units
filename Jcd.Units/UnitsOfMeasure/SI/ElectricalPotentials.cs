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
   public static readonly ElectricalPotential Volt = new("volt", "V", system: "SI");

   /// <summary>
   /// decivolt defined such that: volt = dV × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalPotential Decivolt = new("decivolt", "dV", Volt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centivolt defined such that: decivolt = cV × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalPotential Centivolt = new("centivolt", "cV", Decivolt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millivolt defined such that: centivolt = mV × 1.0/10.0.
   /// </summary>
   public static readonly ElectricalPotential Millivolt = new("millivolt", "mV", Centivolt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microvolt defined such that: millivolt = μV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Microvolt = new("microvolt", "μV", Millivolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanovolt defined such that: microvolt = nV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Nanovolt = new("nanovolt", "nV", Microvolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picovolt defined such that: nanovolt = pV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Picovolt = new("picovolt", "pV", Nanovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtovolt defined such that: picovolt = fV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Femtovolt = new("femtovolt", "fV", Picovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attovolt defined such that: femtovolt = aV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Attovolt = new("attovolt", "aV", Femtovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptovolt defined such that: attovolt = zV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Zeptovolt = new("zeptovolt", "zV", Attovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctovolt defined such that: zeptovolt = yV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Yoctovolt = new("yoctovolt", "yV", Zeptovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontovolt defined such that: yoctovolt = rV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Rontovolt = new("rontovolt", "rV", Yoctovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectovolt defined such that: rontovolt = qV × 1.0/1000.0.
   /// </summary>
   public static readonly ElectricalPotential Quectovolt = new("quectovolt", "qV", Rontovolt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekavolt defined such that: volt = daV × 10.0.
   /// </summary>
   public static readonly ElectricalPotential Dekavolt = new("dekavolt", "daV", Volt, 10.0, system: "SI");

   /// <summary>
   /// hectovolt defined such that: dekavolt = hV × 10.0.
   /// </summary>
   public static readonly ElectricalPotential Hectovolt = new("hectovolt", "hV", Dekavolt, 10.0, system: "SI");

   /// <summary>
   /// kilovolt defined such that: hectovolt = kV × 10.0.
   /// </summary>
   public static readonly ElectricalPotential Kilovolt = new("kilovolt", "kV", Hectovolt, 10.0, system: "SI");

   /// <summary>
   /// megavolt defined such that: kilovolt = MV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Megavolt = new("megavolt", "MV", Kilovolt, 1000.0, system: "SI");

   /// <summary>
   /// gigavolt defined such that: megavolt = GV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Gigavolt = new("gigavolt", "GV", Megavolt, 1000.0, system: "SI");

   /// <summary>
   /// teravolt defined such that: gigavolt = TV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Teravolt = new("teravolt", "TV", Gigavolt, 1000.0, system: "SI");

   /// <summary>
   /// petavolt defined such that: teravolt = PV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Petavolt = new("petavolt", "PV", Teravolt, 1000.0, system: "SI");

   /// <summary>
   /// exavolt defined such that: petavolt = EV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Exavolt = new("exavolt", "EV", Petavolt, 1000.0, system: "SI");

   /// <summary>
   /// zettavolt defined such that: exavolt = ZV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Zettavolt = new("zettavolt", "ZV", Exavolt, 1000.0, system: "SI");

   /// <summary>
   /// yottavolt defined such that: zettavolt = YV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Yottavolt = new("yottavolt", "YV", Zettavolt, 1000.0, system: "SI");

   /// <summary>
   /// ronnavolt defined such that: yottavolt = RV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Ronnavolt = new("ronnavolt", "RV", Yottavolt, 1000.0, system: "SI");

   /// <summary>
   /// quettavolt defined such that: ronnavolt = QV × 1000.0.
   /// </summary>
   public static readonly ElectricalPotential Quettavolt = new("quettavolt", "QV", Ronnavolt, 1000.0, system: "SI");
}