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
/// International System of Units for measuring Power.
/// </summary>
public class Powers : UnitOfMeasureEnumeration<Powers, Power>
{
   /// <summary>
   /// watt, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Power Watt = new ("watt", "W", system: "SI");

   /// <summary>
   /// deciwatt defined such that: watt = dW × 1.0/10.0.
   /// </summary>
   public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiwatt defined such that: deciwatt = cW × 1.0/10.0.
   /// </summary>
   public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliwatt defined such that: centiwatt = mW × 1.0/10.0.
   /// </summary>
   public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microwatt defined such that: milliwatt = μW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanowatt defined such that: microwatt = nW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picowatt defined such that: nanowatt = pW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtowatt defined such that: picowatt = fW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attowatt defined such that: femtowatt = aW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptowatt defined such that: attowatt = zW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctowatt defined such that: zeptowatt = yW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontowatt defined such that: yoctowatt = rW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectowatt defined such that: rontowatt = qW × 1.0/1000.0.
   /// </summary>
   public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekawatt defined such that: watt = daW × 10.0.
   /// </summary>
   public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10.0, system: "SI");

   /// <summary>
   /// hectowatt defined such that: dekawatt = hW × 10.0.
   /// </summary>
   public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10.0, system: "SI");

   /// <summary>
   /// kilowatt defined such that: hectowatt = kW × 10.0.
   /// </summary>
   public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10.0, system: "SI");

   /// <summary>
   /// megawatt defined such that: kilowatt = MW × 1000.0.
   /// </summary>
   public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000.0, system: "SI");

   /// <summary>
   /// gigawatt defined such that: megawatt = GW × 1000.0.
   /// </summary>
   public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000.0, system: "SI");

   /// <summary>
   /// terawatt defined such that: gigawatt = TW × 1000.0.
   /// </summary>
   public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000.0, system: "SI");

   /// <summary>
   /// petawatt defined such that: terawatt = PW × 1000.0.
   /// </summary>
   public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000.0, system: "SI");

   /// <summary>
   /// exawatt defined such that: petawatt = EW × 1000.0.
   /// </summary>
   public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000.0, system: "SI");

   /// <summary>
   /// zettawatt defined such that: exawatt = ZW × 1000.0.
   /// </summary>
   public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000.0, system: "SI");

   /// <summary>
   /// yottawatt defined such that: zettawatt = YW × 1000.0.
   /// </summary>
   public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000.0, system: "SI");

   /// <summary>
   /// ronnawatt defined such that: yottawatt = RW × 1000.0.
   /// </summary>
   public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000.0, system: "SI");

   /// <summary>
   /// quettawatt defined such that: ronnawatt = QW × 1000.0.
   /// </summary>
   public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000.0, system: "SI");
}
