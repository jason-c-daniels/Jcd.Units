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
   public static readonly MagneticFluxDensity Tesla = new ("tesla", "T", system: "SI");

   /// <summary>
   /// decitesla, defined as: tesla × 1.0/10.0
   /// </summary>
   public static readonly MagneticFluxDensity Decitesla = new ("decitesla", "dT", Tesla, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centitesla, defined as: decitesla × 1.0/10.0
   /// </summary>
   public static readonly MagneticFluxDensity
            Centitesla = new ("centitesla", "cT", Decitesla, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millitesla, defined as: centitesla × 1.0/10.0
   /// </summary>
   public static readonly MagneticFluxDensity Millitesla = new (
                                                                "millitesla"
                                                              , "mT"
                                                              , Centitesla
                                                              , 1.0 / 10.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// microtesla, defined as: millitesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Microtesla = new (
                                                                "microtesla"
                                                              , "μT"
                                                              , Millitesla
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// nanotesla, defined as: microtesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Nanotesla = new (
                                                               "nanotesla"
                                                             , "nT"
                                                             , Microtesla
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// picotesla, defined as: nanotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity
            Picotesla = new ("picotesla", "pT", Nanotesla, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtotesla, defined as: picotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Femtotesla = new (
                                                                "femtotesla"
                                                              , "fT"
                                                              , Picotesla
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// attotesla, defined as: femtotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Attotesla = new (
                                                               "attotesla"
                                                             , "aT"
                                                             , Femtotesla
                                                             , 1.0 / 1000.0
                                                             , system: "SI"
                                                              );

   /// <summary>
   /// zeptotesla, defined as: attotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Zeptotesla = new (
                                                                "zeptotesla"
                                                              , "zT"
                                                              , Attotesla
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// yoctotesla, defined as: zeptotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Yoctotesla = new (
                                                                "yoctotesla"
                                                              , "yT"
                                                              , Zeptotesla
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// rontotesla, defined as: yoctotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Rontotesla = new (
                                                                "rontotesla"
                                                              , "rT"
                                                              , Yoctotesla
                                                              , 1.0 / 1000.0
                                                              , system: "SI"
                                                               );

   /// <summary>
   /// quectotesla, defined as: rontotesla × 1.0/1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Quectotesla = new (
                                                                 "quectotesla"
                                                               , "qT"
                                                               , Rontotesla
                                                               , 1.0 / 1000.0
                                                               , system: "SI"
                                                                );

   /// <summary>
   /// dekatesla, defined as: tesla × 10.0
   /// </summary>
   public static readonly MagneticFluxDensity Dekatesla = new ("dekatesla", "daT", Tesla, 10.0, system: "SI");

   /// <summary>
   /// hectotesla, defined as: dekatesla × 10.0
   /// </summary>
   public static readonly MagneticFluxDensity Hectotesla = new ("hectotesla", "hT", Dekatesla, 10.0, system: "SI");

   /// <summary>
   /// kilotesla, defined as: hectotesla × 10.0
   /// </summary>
   public static readonly MagneticFluxDensity Kilotesla = new ("kilotesla", "kT", Hectotesla, 10.0, system: "SI");

   /// <summary>
   /// megatesla, defined as: kilotesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Megatesla = new ("megatesla", "MT", Kilotesla, 1000.0, system: "SI");

   /// <summary>
   /// gigatesla, defined as: megatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Gigatesla = new ("gigatesla", "GT", Megatesla, 1000.0, system: "SI");

   /// <summary>
   /// teratesla, defined as: gigatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Teratesla = new ("teratesla", "TT", Gigatesla, 1000.0, system: "SI");

   /// <summary>
   /// petatesla, defined as: teratesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Petatesla = new ("petatesla", "PT", Teratesla, 1000.0, system: "SI");

   /// <summary>
   /// exatesla, defined as: petatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Exatesla = new ("exatesla", "ET", Petatesla, 1000.0, system: "SI");

   /// <summary>
   /// zettatesla, defined as: exatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Zettatesla = new ("zettatesla", "ZT", Exatesla, 1000.0, system: "SI");

   /// <summary>
   /// yottatesla, defined as: zettatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Yottatesla = new ("yottatesla", "YT", Zettatesla, 1000.0, system: "SI");

   /// <summary>
   /// ronnatesla, defined as: yottatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Ronnatesla = new ("ronnatesla", "RT", Yottatesla, 1000.0, system: "SI");

   /// <summary>
   /// quettatesla, defined as: ronnatesla × 1000.0
   /// </summary>
   public static readonly MagneticFluxDensity Quettatesla = new ("quettatesla", "QT", Ronnatesla, 1000.0, system: "SI");
}
