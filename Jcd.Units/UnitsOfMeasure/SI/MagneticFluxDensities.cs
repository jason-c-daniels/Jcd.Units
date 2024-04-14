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
/// International System of Units for measuring Magnetic Flux Density.
/// </summary>
public class MagneticFluxDensities : UnitOfMeasureEnumeration<MagneticFluxDensities, MagneticFluxDensity>
{
   /// <summary>
   /// tesla, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly MagneticFluxDensity Tesla = new("tesla", "T", system: "SI");

   /// <summary>
   /// decitesla defined such that: tesla = dT × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Decitesla = new("decitesla", "dT", Tesla, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centitesla defined such that: decitesla = cT × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Centitesla = new("centitesla", "cT", Decitesla, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millitesla defined such that: centitesla = mT × 1.0/10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Millitesla = new("millitesla", "mT", Centitesla, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microtesla defined such that: millitesla = μT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Microtesla = new("microtesla", "μT", Millitesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanotesla defined such that: microtesla = nT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Nanotesla = new("nanotesla", "nT", Microtesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picotesla defined such that: nanotesla = pT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Picotesla = new("picotesla", "pT", Nanotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtotesla defined such that: picotesla = fT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Femtotesla = new("femtotesla", "fT", Picotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attotesla defined such that: femtotesla = aT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Attotesla = new("attotesla", "aT", Femtotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptotesla defined such that: attotesla = zT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Zeptotesla = new("zeptotesla", "zT", Attotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctotesla defined such that: zeptotesla = yT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Yoctotesla = new("yoctotesla", "yT", Zeptotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontotesla defined such that: yoctotesla = rT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Rontotesla = new("rontotesla", "rT", Yoctotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectotesla defined such that: rontotesla = qT × 1.0/1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Quectotesla = new("quectotesla", "qT", Rontotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekatesla defined such that: tesla = daT × 10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Dekatesla = new("dekatesla", "daT", Tesla, 10.0, system: "SI");

   /// <summary>
   /// hectotesla defined such that: dekatesla = hT × 10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Hectotesla = new("hectotesla", "hT", Dekatesla, 10.0, system: "SI");

   /// <summary>
   /// kilotesla defined such that: hectotesla = kT × 10.0.
   /// </summary>
   public static readonly MagneticFluxDensity Kilotesla = new("kilotesla", "kT", Hectotesla, 10.0, system: "SI");

   /// <summary>
   /// megatesla defined such that: kilotesla = MT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Megatesla = new("megatesla", "MT", Kilotesla, 1000.0, system: "SI");

   /// <summary>
   /// gigatesla defined such that: megatesla = GT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Gigatesla = new("gigatesla", "GT", Megatesla, 1000.0, system: "SI");

   /// <summary>
   /// teratesla defined such that: gigatesla = TT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Teratesla = new("teratesla", "TT", Gigatesla, 1000.0, system: "SI");

   /// <summary>
   /// petatesla defined such that: teratesla = PT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Petatesla = new("petatesla", "PT", Teratesla, 1000.0, system: "SI");

   /// <summary>
   /// exatesla defined such that: petatesla = ET × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Exatesla = new("exatesla", "ET", Petatesla, 1000.0, system: "SI");

   /// <summary>
   /// zettatesla defined such that: exatesla = ZT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Zettatesla = new("zettatesla", "ZT", Exatesla, 1000.0, system: "SI");

   /// <summary>
   /// yottatesla defined such that: zettatesla = YT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Yottatesla = new("yottatesla", "YT", Zettatesla, 1000.0, system: "SI");

   /// <summary>
   /// ronnatesla defined such that: yottatesla = RT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Ronnatesla = new("ronnatesla", "RT", Yottatesla, 1000.0, system: "SI");

   /// <summary>
   /// quettatesla defined such that: ronnatesla = QT × 1000.0.
   /// </summary>
   public static readonly MagneticFluxDensity Quettatesla = new("quettatesla", "QT", Ronnatesla, 1000.0, system: "SI");
}