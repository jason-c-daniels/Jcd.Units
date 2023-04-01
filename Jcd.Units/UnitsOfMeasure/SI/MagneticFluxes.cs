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
/// International System of Units for measuring Magnetic Flux.
/// </summary>
public class MagneticFluxes : UnitOfMeasureEnumeration<MagneticFluxes, MagneticFlux>
{
   /// <summary>
   /// weber, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly MagneticFlux Weber = new ("weber", "Wb", system: "SI");

   /// <summary>
   /// deciweber, defined as: weber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiweber, defined as: deciweber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliweber, defined as: centiweber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microweber, defined as: milliweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanoweber, defined as: microweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picoweber, defined as: nanoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtoweber, defined as: picoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attoweber, defined as: femtoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptoweber, defined as: attoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctoweber, defined as: zeptoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontoweber, defined as: yoctoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectoweber, defined as: rontoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekaweber, defined as: weber × 10.0
   /// </summary>
   public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10.0, system: "SI");

   /// <summary>
   /// hectoweber, defined as: dekaweber × 10.0
   /// </summary>
   public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10.0, system: "SI");

   /// <summary>
   /// kiloweber, defined as: hectoweber × 10.0
   /// </summary>
   public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10.0, system: "SI");

   /// <summary>
   /// megaweber, defined as: kiloweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000.0, system: "SI");

   /// <summary>
   /// gigaweber, defined as: megaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000.0, system: "SI");

   /// <summary>
   /// teraweber, defined as: gigaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000.0, system: "SI");

   /// <summary>
   /// petaweber, defined as: teraweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000.0, system: "SI");

   /// <summary>
   /// exaweber, defined as: petaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000.0, system: "SI");

   /// <summary>
   /// zettaweber, defined as: exaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000.0, system: "SI");

   /// <summary>
   /// yottaweber, defined as: zettaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000.0, system: "SI");

   /// <summary>
   /// ronnaweber, defined as: yottaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000.0, system: "SI");

   /// <summary>
   /// quettaweber, defined as: ronnaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000.0, system: "SI");
}
