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
   /// deciweber defined such that: weber = dWb × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centiweber defined such that: deciweber = cWb × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milliweber defined such that: centiweber = mWb × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microweber defined such that: milliweber = μWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanoweber defined such that: microweber = nWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picoweber defined such that: nanoweber = pWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtoweber defined such that: picoweber = fWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attoweber defined such that: femtoweber = aWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptoweber defined such that: attoweber = zWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctoweber defined such that: zeptoweber = yWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontoweber defined such that: yoctoweber = rWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectoweber defined such that: rontoweber = qWb × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekaweber defined such that: weber = daWb × 10.0.
   /// </summary>
   public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10.0, system: "SI");

   /// <summary>
   /// hectoweber defined such that: dekaweber = hWb × 10.0.
   /// </summary>
   public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10.0, system: "SI");

   /// <summary>
   /// kiloweber defined such that: hectoweber = kWb × 10.0.
   /// </summary>
   public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10.0, system: "SI");

   /// <summary>
   /// megaweber defined such that: kiloweber = MWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000.0, system: "SI");

   /// <summary>
   /// gigaweber defined such that: megaweber = GWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000.0, system: "SI");

   /// <summary>
   /// teraweber defined such that: gigaweber = TWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000.0, system: "SI");

   /// <summary>
   /// petaweber defined such that: teraweber = PWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000.0, system: "SI");

   /// <summary>
   /// exaweber defined such that: petaweber = EWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000.0, system: "SI");

   /// <summary>
   /// zettaweber defined such that: exaweber = ZWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000.0, system: "SI");

   /// <summary>
   /// yottaweber defined such that: zettaweber = YWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000.0, system: "SI");

   /// <summary>
   /// ronnaweber defined such that: yottaweber = RWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000.0, system: "SI");

   /// <summary>
   /// quettaweber defined such that: ronnaweber = QWb × 1000.0.
   /// </summary>
   public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000.0, system: "SI");
}
