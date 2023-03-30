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
   public static readonly Power Watt = new ("watt", "W");

   /// <summary>
   /// deciwatt, defined as: watt × 1.0/10.0
   /// </summary>
   public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0 / 10.0);

   /// <summary>
   /// centiwatt, defined as: deciwatt × 1.0/10.0
   /// </summary>
   public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0 / 10.0);

   /// <summary>
   /// milliwatt, defined as: centiwatt × 1.0/10.0
   /// </summary>
   public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0 / 10.0);

   /// <summary>
   /// microwatt, defined as: milliwatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0 / 1000.0);

   /// <summary>
   /// nanowatt, defined as: microwatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0 / 1000.0);

   /// <summary>
   /// picowatt, defined as: nanowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0 / 1000.0);

   /// <summary>
   /// femtowatt, defined as: picowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0 / 1000.0);

   /// <summary>
   /// attowatt, defined as: femtowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0 / 1000.0);

   /// <summary>
   /// zeptowatt, defined as: attowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0 / 1000.0);

   /// <summary>
   /// yoctowatt, defined as: zeptowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0 / 1000.0);

   /// <summary>
   /// rontowatt, defined as: yoctowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0 / 1000.0);

   /// <summary>
   /// quectowatt, defined as: rontowatt × 1.0/1000.0
   /// </summary>
   public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0 / 1000.0);

   /// <summary>
   /// dekawatt, defined as: watt × 10.0
   /// </summary>
   public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10.0);

   /// <summary>
   /// hectowatt, defined as: dekawatt × 10.0
   /// </summary>
   public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10.0);

   /// <summary>
   /// kilowatt, defined as: hectowatt × 10.0
   /// </summary>
   public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10.0);

   /// <summary>
   /// megawatt, defined as: kilowatt × 1000.0
   /// </summary>
   public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000.0);

   /// <summary>
   /// gigawatt, defined as: megawatt × 1000.0
   /// </summary>
   public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000.0);

   /// <summary>
   /// terawatt, defined as: gigawatt × 1000.0
   /// </summary>
   public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000.0);

   /// <summary>
   /// petawatt, defined as: terawatt × 1000.0
   /// </summary>
   public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000.0);

   /// <summary>
   /// exawatt, defined as: petawatt × 1000.0
   /// </summary>
   public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000.0);

   /// <summary>
   /// zettawatt, defined as: exawatt × 1000.0
   /// </summary>
   public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000.0);

   /// <summary>
   /// yottawatt, defined as: zettawatt × 1000.0
   /// </summary>
   public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000.0);

   /// <summary>
   /// ronnawatt, defined as: yottawatt × 1000.0
   /// </summary>
   public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000.0);

   /// <summary>
   /// quettawatt, defined as: ronnawatt × 1000.0
   /// </summary>
   public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000.0);
}
