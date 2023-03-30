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
   public static readonly MagneticFlux Weber = new ("weber", "Wb");

   /// <summary>
   /// deciweber, defined as: weber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0 / 10.0);

   /// <summary>
   /// centiweber, defined as: deciweber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0 / 10.0);

   /// <summary>
   /// milliweber, defined as: centiweber × 1.0/10.0
   /// </summary>
   public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0 / 10.0);

   /// <summary>
   /// microweber, defined as: milliweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0 / 1000.0);

   /// <summary>
   /// nanoweber, defined as: microweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0 / 1000.0);

   /// <summary>
   /// picoweber, defined as: nanoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0 / 1000.0);

   /// <summary>
   /// femtoweber, defined as: picoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0 / 1000.0);

   /// <summary>
   /// attoweber, defined as: femtoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0 / 1000.0);

   /// <summary>
   /// zeptoweber, defined as: attoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0 / 1000.0);

   /// <summary>
   /// yoctoweber, defined as: zeptoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0 / 1000.0);

   /// <summary>
   /// rontoweber, defined as: yoctoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0 / 1000.0);

   /// <summary>
   /// quectoweber, defined as: rontoweber × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0 / 1000.0);

   /// <summary>
   /// dekaweber, defined as: weber × 10.0
   /// </summary>
   public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10.0);

   /// <summary>
   /// hectoweber, defined as: dekaweber × 10.0
   /// </summary>
   public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10.0);

   /// <summary>
   /// kiloweber, defined as: hectoweber × 10.0
   /// </summary>
   public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10.0);

   /// <summary>
   /// megaweber, defined as: kiloweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000.0);

   /// <summary>
   /// gigaweber, defined as: megaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000.0);

   /// <summary>
   /// teraweber, defined as: gigaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000.0);

   /// <summary>
   /// petaweber, defined as: teraweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000.0);

   /// <summary>
   /// exaweber, defined as: petaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000.0);

   /// <summary>
   /// zettaweber, defined as: exaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000.0);

   /// <summary>
   /// yottaweber, defined as: zettaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000.0);

   /// <summary>
   /// ronnaweber, defined as: yottaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000.0);

   /// <summary>
   /// quettaweber, defined as: ronnaweber × 1000.0
   /// </summary>
   public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000.0);
}
