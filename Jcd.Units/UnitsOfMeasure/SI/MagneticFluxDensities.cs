using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Magnetic Flux Density.
/// </summary>
public class MagneticFluxDensities : Enumeration<MagneticFluxDensities,MagneticFluxDensity>
{

    /// <summary>
    /// A(n) tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Tesla = new ("tesla", "T");

    /// <summary>
    /// A(n) decitesla. Defined in terms of a(n) tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Decitesla = new ("decitesla", "dT", Tesla, 1.0/10.0,0);

    /// <summary>
    /// A(n) centitesla. Defined in terms of a(n) decitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Centitesla = new ("centitesla", "cT", Decitesla, 1.0/10.0,0);

    /// <summary>
    /// A(n) millitesla. Defined in terms of a(n) centitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Millitesla = new ("millitesla", "mT", Centitesla, 1.0/10.0,0);

    /// <summary>
    /// A(n) microtesla. Defined in terms of a(n) millitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Microtesla = new ("microtesla", "μT", Millitesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanotesla. Defined in terms of a(n) microtesla.
    /// </summary>
    public static readonly MagneticFluxDensity Nanotesla = new ("nanotesla", "nT", Microtesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picotesla. Defined in terms of a(n) nanotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Picotesla = new ("picotesla", "pT", Nanotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtotesla. Defined in terms of a(n) picotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Femtotesla = new ("femtotesla", "fT", Picotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attotesla. Defined in terms of a(n) femtotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Attotesla = new ("attotesla", "aT", Femtotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptotesla. Defined in terms of a(n) attotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Zeptotesla = new ("zeptotesla", "zT", Attotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctotesla. Defined in terms of a(n) zeptotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Yoctotesla = new ("yoctotesla", "yT", Zeptotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontotesla. Defined in terms of a(n) yoctotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Rontotesla = new ("rontotesla", "rT", Yoctotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectotesla. Defined in terms of a(n) rontotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Quectotesla = new ("quectotesla", "qT", Rontotesla, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekatesla. Defined in terms of a(n) tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Dekatesla = new ("dekatesla", "daT", Tesla, 10,0);

    /// <summary>
    /// A(n) hectotesla. Defined in terms of a(n) dekatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Hectotesla = new ("hectotesla", "hT", Dekatesla, 10,0);

    /// <summary>
    /// A(n) kilotesla. Defined in terms of a(n) hectotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Kilotesla = new ("kilotesla", "kT", Hectotesla, 10,0);

    /// <summary>
    /// A(n) megatesla. Defined in terms of a(n) kilotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Megatesla = new ("megatesla", "MT", Kilotesla, 1000,0);

    /// <summary>
    /// A(n) gigatesla. Defined in terms of a(n) megatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Gigatesla = new ("gigatesla", "GT", Megatesla, 1000,0);

    /// <summary>
    /// A(n) teratesla. Defined in terms of a(n) gigatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Teratesla = new ("teratesla", "TT", Gigatesla, 1000,0);

    /// <summary>
    /// A(n) petatesla. Defined in terms of a(n) teratesla.
    /// </summary>
    public static readonly MagneticFluxDensity Petatesla = new ("petatesla", "PT", Teratesla, 1000,0);

    /// <summary>
    /// A(n) exatesla. Defined in terms of a(n) petatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Exatesla = new ("exatesla", "ET", Petatesla, 1000,0);

    /// <summary>
    /// A(n) zettatesla. Defined in terms of a(n) exatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Zettatesla = new ("zettatesla", "ZT", Exatesla, 1000,0);

    /// <summary>
    /// A(n) yottatesla. Defined in terms of a(n) zettatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Yottatesla = new ("yottatesla", "YT", Zettatesla, 1000,0);

    /// <summary>
    /// A(n) ronnatesla. Defined in terms of a(n) yottatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Ronnatesla = new ("ronnatesla", "RT", Yottatesla, 1000,0);

    /// <summary>
    /// A(n) quettatesla. Defined in terms of a(n) ronnatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Quettatesla = new ("quettatesla", "QT", Ronnatesla, 1000,0);

}