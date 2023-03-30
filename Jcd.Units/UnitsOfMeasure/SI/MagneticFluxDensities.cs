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
   /// A(n) tesla.
   /// </summary>
   public static readonly MagneticFluxDensity Tesla = new ("tesla", "T");

   /// <summary>
   /// A(n) decitesla. Defined as: 1.0/10.0 × tesla.
   /// </summary>
   public static readonly MagneticFluxDensity Decitesla = new ("decitesla", "dT", Tesla, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centitesla. Defined as: 1.0/10.0 × decitesla.
   /// </summary>
   public static readonly MagneticFluxDensity Centitesla = new ("centitesla", "cT", Decitesla, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millitesla. Defined as: 1.0/10.0 × centitesla.
   /// </summary>
   public static readonly MagneticFluxDensity Millitesla = new ("millitesla", "mT", Centitesla, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microtesla. Defined as: 1.0/1000.0 × millitesla.
   /// </summary>
   public static readonly MagneticFluxDensity Microtesla = new ("microtesla", "μT", Millitesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanotesla. Defined as: 1.0/1000.0 × microtesla.
   /// </summary>
   public static readonly MagneticFluxDensity Nanotesla = new ("nanotesla", "nT", Microtesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picotesla. Defined as: 1.0/1000.0 × nanotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Picotesla = new ("picotesla", "pT", Nanotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtotesla. Defined as: 1.0/1000.0 × picotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Femtotesla = new ("femtotesla", "fT", Picotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attotesla. Defined as: 1.0/1000.0 × femtotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Attotesla = new ("attotesla", "aT", Femtotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptotesla. Defined as: 1.0/1000.0 × attotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Zeptotesla = new ("zeptotesla", "zT", Attotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctotesla. Defined as: 1.0/1000.0 × zeptotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Yoctotesla = new ("yoctotesla", "yT", Zeptotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontotesla. Defined as: 1.0/1000.0 × yoctotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Rontotesla = new ("rontotesla", "rT", Yoctotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectotesla. Defined as: 1.0/1000.0 × rontotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Quectotesla = new ("quectotesla", "qT", Rontotesla, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekatesla. Defined as: 10.0 × tesla.
   /// </summary>
   public static readonly MagneticFluxDensity Dekatesla = new ("dekatesla", "daT", Tesla, 10.0, 0);

   /// <summary>
   /// A(n) hectotesla. Defined as: 10.0 × dekatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Hectotesla = new ("hectotesla", "hT", Dekatesla, 10.0, 0);

   /// <summary>
   /// A(n) kilotesla. Defined as: 10.0 × hectotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Kilotesla = new ("kilotesla", "kT", Hectotesla, 10.0, 0);

   /// <summary>
   /// A(n) megatesla. Defined as: 1000.0 × kilotesla.
   /// </summary>
   public static readonly MagneticFluxDensity Megatesla = new ("megatesla", "MT", Kilotesla, 1000.0, 0);

   /// <summary>
   /// A(n) gigatesla. Defined as: 1000.0 × megatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Gigatesla = new ("gigatesla", "GT", Megatesla, 1000.0, 0);

   /// <summary>
   /// A(n) teratesla. Defined as: 1000.0 × gigatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Teratesla = new ("teratesla", "TT", Gigatesla, 1000.0, 0);

   /// <summary>
   /// A(n) petatesla. Defined as: 1000.0 × teratesla.
   /// </summary>
   public static readonly MagneticFluxDensity Petatesla = new ("petatesla", "PT", Teratesla, 1000.0, 0);

   /// <summary>
   /// A(n) exatesla. Defined as: 1000.0 × petatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Exatesla = new ("exatesla", "ET", Petatesla, 1000.0, 0);

   /// <summary>
   /// A(n) zettatesla. Defined as: 1000.0 × exatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Zettatesla = new ("zettatesla", "ZT", Exatesla, 1000.0, 0);

   /// <summary>
   /// A(n) yottatesla. Defined as: 1000.0 × zettatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Yottatesla = new ("yottatesla", "YT", Zettatesla, 1000.0, 0);

   /// <summary>
   /// A(n) ronnatesla. Defined as: 1000.0 × yottatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Ronnatesla = new ("ronnatesla", "RT", Yottatesla, 1000.0, 0);

   /// <summary>
   /// A(n) quettatesla. Defined as: 1000.0 × ronnatesla.
   /// </summary>
   public static readonly MagneticFluxDensity Quettatesla = new ("quettatesla", "QT", Ronnatesla, 1000.0, 0);
}
