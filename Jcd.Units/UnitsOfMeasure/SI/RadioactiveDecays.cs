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
/// International System of Units for measuring Radioactive Decay.
/// </summary>
public class RadioactiveDecays : UnitOfMeasureEnumeration<RadioactiveDecays, RadioactiveDecay>
{
   /// <summary>
   /// becquerel, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly RadioactiveDecay Becquerel = new("becquerel", "Bq", system: "SI");

   /// <summary>
   /// decibecquerel defined such that: becquerel = dBq × 1.0/10.0.
   /// </summary>
   public static readonly RadioactiveDecay Decibecquerel = new("decibecquerel", "dBq", Becquerel, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centibecquerel defined such that: decibecquerel = cBq × 1.0/10.0.
   /// </summary>
   public static readonly RadioactiveDecay Centibecquerel = new("centibecquerel", "cBq", Decibecquerel, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millibecquerel defined such that: centibecquerel = mBq × 1.0/10.0.
   /// </summary>
   public static readonly RadioactiveDecay Millibecquerel = new("millibecquerel", "mBq", Centibecquerel, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microbecquerel defined such that: millibecquerel = μBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Microbecquerel = new("microbecquerel", "μBq", Millibecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanobecquerel defined such that: microbecquerel = nBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Nanobecquerel = new("nanobecquerel", "nBq", Microbecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picobecquerel defined such that: nanobecquerel = pBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Picobecquerel = new("picobecquerel", "pBq", Nanobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtobecquerel defined such that: picobecquerel = fBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Femtobecquerel = new("femtobecquerel", "fBq", Picobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attobecquerel defined such that: femtobecquerel = aBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Attobecquerel = new("attobecquerel", "aBq", Femtobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptobecquerel defined such that: attobecquerel = zBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Zeptobecquerel = new("zeptobecquerel", "zBq", Attobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctobecquerel defined such that: zeptobecquerel = yBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Yoctobecquerel = new("yoctobecquerel", "yBq", Zeptobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontobecquerel defined such that: yoctobecquerel = rBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Rontobecquerel = new("rontobecquerel", "rBq", Yoctobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectobecquerel defined such that: rontobecquerel = qBq × 1.0/1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Quectobecquerel = new("quectobecquerel", "qBq", Rontobecquerel, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekabecquerel defined such that: becquerel = daBq × 10.0.
   /// </summary>
   public static readonly RadioactiveDecay Dekabecquerel = new("dekabecquerel", "daBq", Becquerel, 10.0, system: "SI");

   /// <summary>
   /// hectobecquerel defined such that: dekabecquerel = hBq × 10.0.
   /// </summary>
   public static readonly RadioactiveDecay Hectobecquerel = new("hectobecquerel", "hBq", Dekabecquerel, 10.0, system: "SI");

   /// <summary>
   /// kilobecquerel defined such that: hectobecquerel = kBq × 10.0.
   /// </summary>
   public static readonly RadioactiveDecay Kilobecquerel = new("kilobecquerel", "kBq", Hectobecquerel, 10.0, system: "SI");

   /// <summary>
   /// megabecquerel defined such that: kilobecquerel = MBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Megabecquerel = new("megabecquerel", "MBq", Kilobecquerel, 1000.0, system: "SI");

   /// <summary>
   /// gigabecquerel defined such that: megabecquerel = GBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Gigabecquerel = new("gigabecquerel", "GBq", Megabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// terabecquerel defined such that: gigabecquerel = TBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Terabecquerel = new("terabecquerel", "TBq", Gigabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// petabecquerel defined such that: terabecquerel = PBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Petabecquerel = new("petabecquerel", "PBq", Terabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// exabecquerel defined such that: petabecquerel = EBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Exabecquerel = new("exabecquerel", "EBq", Petabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// zettabecquerel defined such that: exabecquerel = ZBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Zettabecquerel = new("zettabecquerel", "ZBq", Exabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// yottabecquerel defined such that: zettabecquerel = YBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Yottabecquerel = new("yottabecquerel", "YBq", Zettabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// ronnabecquerel defined such that: yottabecquerel = RBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Ronnabecquerel = new("ronnabecquerel", "RBq", Yottabecquerel, 1000.0, system: "SI");

   /// <summary>
   /// quettabecquerel defined such that: ronnabecquerel = QBq × 1000.0.
   /// </summary>
   public static readonly RadioactiveDecay Quettabecquerel = new("quettabecquerel", "QBq", Ronnabecquerel, 1000.0, system: "SI");
}