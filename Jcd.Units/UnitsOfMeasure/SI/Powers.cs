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
   /// A(n) watt.
   /// </summary>
   public static readonly Power Watt = new ("watt", "W");

   /// <summary>
   /// A(n) deciwatt. Defined as: 1.0/10.0 × watt.
   /// </summary>
   public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centiwatt. Defined as: 1.0/10.0 × deciwatt.
   /// </summary>
   public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milliwatt. Defined as: 1.0/10.0 × centiwatt.
   /// </summary>
   public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microwatt. Defined as: 1.0/1000.0 × milliwatt.
   /// </summary>
   public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanowatt. Defined as: 1.0/1000.0 × microwatt.
   /// </summary>
   public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picowatt. Defined as: 1.0/1000.0 × nanowatt.
   /// </summary>
   public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtowatt. Defined as: 1.0/1000.0 × picowatt.
   /// </summary>
   public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attowatt. Defined as: 1.0/1000.0 × femtowatt.
   /// </summary>
   public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptowatt. Defined as: 1.0/1000.0 × attowatt.
   /// </summary>
   public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctowatt. Defined as: 1.0/1000.0 × zeptowatt.
   /// </summary>
   public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontowatt. Defined as: 1.0/1000.0 × yoctowatt.
   /// </summary>
   public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectowatt. Defined as: 1.0/1000.0 × rontowatt.
   /// </summary>
   public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekawatt. Defined as: 10.0 × watt.
   /// </summary>
   public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10.0, 0);

   /// <summary>
   /// A(n) hectowatt. Defined as: 10.0 × dekawatt.
   /// </summary>
   public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10.0, 0);

   /// <summary>
   /// A(n) kilowatt. Defined as: 10.0 × hectowatt.
   /// </summary>
   public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10.0, 0);

   /// <summary>
   /// A(n) megawatt. Defined as: 1000.0 × kilowatt.
   /// </summary>
   public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000.0, 0);

   /// <summary>
   /// A(n) gigawatt. Defined as: 1000.0 × megawatt.
   /// </summary>
   public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000.0, 0);

   /// <summary>
   /// A(n) terawatt. Defined as: 1000.0 × gigawatt.
   /// </summary>
   public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000.0, 0);

   /// <summary>
   /// A(n) petawatt. Defined as: 1000.0 × terawatt.
   /// </summary>
   public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000.0, 0);

   /// <summary>
   /// A(n) exawatt. Defined as: 1000.0 × petawatt.
   /// </summary>
   public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000.0, 0);

   /// <summary>
   /// A(n) zettawatt. Defined as: 1000.0 × exawatt.
   /// </summary>
   public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000.0, 0);

   /// <summary>
   /// A(n) yottawatt. Defined as: 1000.0 × zettawatt.
   /// </summary>
   public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000.0, 0);

   /// <summary>
   /// A(n) ronnawatt. Defined as: 1000.0 × yottawatt.
   /// </summary>
   public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000.0, 0);

   /// <summary>
   /// A(n) quettawatt. Defined as: 1000.0 × ronnawatt.
   /// </summary>
   public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000.0, 0);
}
