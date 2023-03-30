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
   /// A(n) weber.
   /// </summary>
   public static readonly MagneticFlux Weber = new ("weber", "Wb");

   /// <summary>
   /// A(n) deciweber. Defined as: 1.0/10.0 × weber.
   /// </summary>
   public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centiweber. Defined as: 1.0/10.0 × deciweber.
   /// </summary>
   public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milliweber. Defined as: 1.0/10.0 × centiweber.
   /// </summary>
   public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microweber. Defined as: 1.0/1000.0 × milliweber.
   /// </summary>
   public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanoweber. Defined as: 1.0/1000.0 × microweber.
   /// </summary>
   public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picoweber. Defined as: 1.0/1000.0 × nanoweber.
   /// </summary>
   public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtoweber. Defined as: 1.0/1000.0 × picoweber.
   /// </summary>
   public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attoweber. Defined as: 1.0/1000.0 × femtoweber.
   /// </summary>
   public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptoweber. Defined as: 1.0/1000.0 × attoweber.
   /// </summary>
   public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctoweber. Defined as: 1.0/1000.0 × zeptoweber.
   /// </summary>
   public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontoweber. Defined as: 1.0/1000.0 × yoctoweber.
   /// </summary>
   public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectoweber. Defined as: 1.0/1000.0 × rontoweber.
   /// </summary>
   public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekaweber. Defined as: 10.0 × weber.
   /// </summary>
   public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10.0, 0);

   /// <summary>
   /// A(n) hectoweber. Defined as: 10.0 × dekaweber.
   /// </summary>
   public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10.0, 0);

   /// <summary>
   /// A(n) kiloweber. Defined as: 10.0 × hectoweber.
   /// </summary>
   public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10.0, 0);

   /// <summary>
   /// A(n) megaweber. Defined as: 1000.0 × kiloweber.
   /// </summary>
   public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000.0, 0);

   /// <summary>
   /// A(n) gigaweber. Defined as: 1000.0 × megaweber.
   /// </summary>
   public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000.0, 0);

   /// <summary>
   /// A(n) teraweber. Defined as: 1000.0 × gigaweber.
   /// </summary>
   public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000.0, 0);

   /// <summary>
   /// A(n) petaweber. Defined as: 1000.0 × teraweber.
   /// </summary>
   public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000.0, 0);

   /// <summary>
   /// A(n) exaweber. Defined as: 1000.0 × petaweber.
   /// </summary>
   public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000.0, 0);

   /// <summary>
   /// A(n) zettaweber. Defined as: 1000.0 × exaweber.
   /// </summary>
   public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000.0, 0);

   /// <summary>
   /// A(n) yottaweber. Defined as: 1000.0 × zettaweber.
   /// </summary>
   public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000.0, 0);

   /// <summary>
   /// A(n) ronnaweber. Defined as: 1000.0 × yottaweber.
   /// </summary>
   public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000.0, 0);

   /// <summary>
   /// A(n) quettaweber. Defined as: 1000.0 × ronnaweber.
   /// </summary>
   public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000.0, 0);
}
