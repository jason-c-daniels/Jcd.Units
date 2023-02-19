using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Magnetic Flux Density.
/// </summary>
public class MagneticFluxDensities : Enumeration<MagneticFluxDensities,MagneticFluxDensity>
{

    /// <summary>
    /// Units of a tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Tesla = new ("tesla", "T");
    /// <summary>
    /// Units of a decitesla. It's defined in terms of a(n) SI tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Decitesla = new ("decitesla", "dT", Tesla, 1.0/10.0,0);
    /// <summary>
    /// Units of a centitesla. It's defined in terms of a(n) SI decitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Centitesla = new ("centitesla", "cT", Decitesla, 1.0/10.0,0);
    /// <summary>
    /// Units of a millitesla. It's defined in terms of a(n) SI centitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Millitesla = new ("millitesla", "mT", Centitesla, 1.0/10.0,0);
    /// <summary>
    /// Units of a microtesla. It's defined in terms of a(n) SI millitesla.
    /// </summary>
    public static readonly MagneticFluxDensity Microtesla = new ("microtesla", "μT", Millitesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanotesla. It's defined in terms of a(n) SI microtesla.
    /// </summary>
    public static readonly MagneticFluxDensity Nanotesla = new ("nanotesla", "nT", Microtesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picotesla. It's defined in terms of a(n) SI nanotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Picotesla = new ("picotesla", "pT", Nanotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtotesla. It's defined in terms of a(n) SI picotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Femtotesla = new ("femtotesla", "fT", Picotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attotesla. It's defined in terms of a(n) SI femtotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Attotesla = new ("attotesla", "aT", Femtotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptotesla. It's defined in terms of a(n) SI attotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Zeptotesla = new ("zeptotesla", "zT", Attotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctotesla. It's defined in terms of a(n) SI zeptotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Yoctotesla = new ("yoctotesla", "yT", Zeptotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontotesla. It's defined in terms of a(n) SI yoctotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Rontotesla = new ("rontotesla", "rT", Yoctotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectotesla. It's defined in terms of a(n) SI rontotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Quectotesla = new ("quectotesla", "qT", Rontotesla, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekatesla. It's defined in terms of a(n) SI tesla.
    /// </summary>
    public static readonly MagneticFluxDensity Dekatesla = new ("dekatesla", "daT", Tesla, 10,0);
    /// <summary>
    /// Units of a hectotesla. It's defined in terms of a(n) SI dekatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Hectotesla = new ("hectotesla", "hT", Dekatesla, 10,0);
    /// <summary>
    /// Units of a kilotesla. It's defined in terms of a(n) SI hectotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Kilotesla = new ("kilotesla", "kT", Hectotesla, 10,0);
    /// <summary>
    /// Units of a megatesla. It's defined in terms of a(n) SI kilotesla.
    /// </summary>
    public static readonly MagneticFluxDensity Megatesla = new ("megatesla", "MT", Kilotesla, 1000,0);
    /// <summary>
    /// Units of a gigatesla. It's defined in terms of a(n) SI megatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Gigatesla = new ("gigatesla", "GT", Megatesla, 1000,0);
    /// <summary>
    /// Units of a teratesla. It's defined in terms of a(n) SI gigatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Teratesla = new ("teratesla", "TT", Gigatesla, 1000,0);
    /// <summary>
    /// Units of a petatesla. It's defined in terms of a(n) SI teratesla.
    /// </summary>
    public static readonly MagneticFluxDensity Petatesla = new ("petatesla", "PT", Teratesla, 1000,0);
    /// <summary>
    /// Units of a exatesla. It's defined in terms of a(n) SI petatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Exatesla = new ("exatesla", "ET", Petatesla, 1000,0);
    /// <summary>
    /// Units of a zettatesla. It's defined in terms of a(n) SI exatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Zettatesla = new ("zettatesla", "ZT", Exatesla, 1000,0);
    /// <summary>
    /// Units of a yottatesla. It's defined in terms of a(n) SI zettatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Yottatesla = new ("yottatesla", "YT", Zettatesla, 1000,0);
    /// <summary>
    /// Units of a ronnatesla. It's defined in terms of a(n) SI yottatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Ronnatesla = new ("ronnatesla", "RT", Yottatesla, 1000,0);
    /// <summary>
    /// Units of a quettatesla. It's defined in terms of a(n) SI ronnatesla.
    /// </summary>
    public static readonly MagneticFluxDensity Quettatesla = new ("quettatesla", "QT", Ronnatesla, 1000,0);

}