using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class MagneticFluxDensities : Enumeration<MagneticFluxDensities,MagneticFluxDensity>
{
    public static readonly MagneticFluxDensity Tesla = new ("tesla", "T");
    public static readonly MagneticFluxDensity Decitesla = new ("decitesla", "dT", Tesla, 1.0/10.0,0);
    public static readonly MagneticFluxDensity Centitesla = new ("centitesla", "cT", Decitesla, 1.0/10.0,0);
    public static readonly MagneticFluxDensity Millitesla = new ("millitesla", "mT", Centitesla, 1.0/10.0,0);
    public static readonly MagneticFluxDensity Microtesla = new ("microtesla", "μT", Millitesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Nanotesla = new ("nanotesla", "nT", Microtesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Picotesla = new ("picotesla", "pT", Nanotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Femtotesla = new ("femtotesla", "fT", Picotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Attotesla = new ("attotesla", "aT", Femtotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Zeptotesla = new ("zeptotesla", "zT", Attotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Yoctotesla = new ("yoctotesla", "yT", Zeptotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Rontotesla = new ("rontotesla", "rT", Yoctotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Quectotesla = new ("quectotesla", "qT", Rontotesla, 1.0/1000.0,0);
    public static readonly MagneticFluxDensity Dekatesla = new ("dekatesla", "daT", Tesla, 10,0);
    public static readonly MagneticFluxDensity Hectotesla = new ("hectotesla", "hT", Dekatesla, 10,0);
    public static readonly MagneticFluxDensity Kilotesla = new ("kilotesla", "kT", Hectotesla, 10,0);
    public static readonly MagneticFluxDensity Megatesla = new ("megatesla", "MT", Kilotesla, 1000,0);
    public static readonly MagneticFluxDensity Gigatesla = new ("gigatesla", "GT", Megatesla, 1000,0);
    public static readonly MagneticFluxDensity Teratesla = new ("teratesla", "TT", Gigatesla, 1000,0);
    public static readonly MagneticFluxDensity Petatesla = new ("petatesla", "PT", Teratesla, 1000,0);
    public static readonly MagneticFluxDensity Exatesla = new ("exatesla", "ET", Petatesla, 1000,0);
    public static readonly MagneticFluxDensity Zettatesla = new ("zettatesla", "ZT", Exatesla, 1000,0);
    public static readonly MagneticFluxDensity Yottatesla = new ("yottatesla", "YT", Zettatesla, 1000,0);
    public static readonly MagneticFluxDensity Ronnatesla = new ("ronnatesla", "RT", Yottatesla, 1000,0);
    public static readonly MagneticFluxDensity Quettatesla = new ("quettatesla", "QT", Ronnatesla, 1000,0);
}