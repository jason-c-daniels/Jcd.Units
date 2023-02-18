using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Luminous Intensity.
/// </summary>
public class LuminousIntensities : Enumeration<LuminousIntensities,LuminousIntensity>
{
    public static readonly LuminousIntensity Candela = new ("candela", "cd");
    public static readonly LuminousIntensity Decicandela = new ("decicandela", "dcd", Candela, 1.0/10.0,0);
    public static readonly LuminousIntensity Centicandela = new ("centicandela", "ccd", Decicandela, 1.0/10.0,0);
    public static readonly LuminousIntensity Millicandela = new ("millicandela", "mcd", Centicandela, 1.0/10.0,0);
    public static readonly LuminousIntensity Microcandela = new ("microcandela", "μcd", Millicandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Nanocandela = new ("nanocandela", "ncd", Microcandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Picocandela = new ("picocandela", "pcd", Nanocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Femtocandela = new ("femtocandela", "fcd", Picocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Attocandela = new ("attocandela", "acd", Femtocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Zeptocandela = new ("zeptocandela", "zcd", Attocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Yoctocandela = new ("yoctocandela", "ycd", Zeptocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Rontocandela = new ("rontocandela", "rcd", Yoctocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Quectocandela = new ("quectocandela", "qcd", Rontocandela, 1.0/1000.0,0);
    public static readonly LuminousIntensity Dekacandela = new ("dekacandela", "dacd", Candela, 10,0);
    public static readonly LuminousIntensity Hectocandela = new ("hectocandela", "hcd", Dekacandela, 10,0);
    public static readonly LuminousIntensity Kilocandela = new ("kilocandela", "kcd", Hectocandela, 10,0);
    public static readonly LuminousIntensity Megacandela = new ("megacandela", "Mcd", Kilocandela, 1000,0);
    public static readonly LuminousIntensity Gigacandela = new ("gigacandela", "Gcd", Megacandela, 1000,0);
    public static readonly LuminousIntensity Teracandela = new ("teracandela", "Tcd", Gigacandela, 1000,0);
    public static readonly LuminousIntensity Petacandela = new ("petacandela", "Pcd", Teracandela, 1000,0);
    public static readonly LuminousIntensity Exacandela = new ("exacandela", "Ecd", Petacandela, 1000,0);
    public static readonly LuminousIntensity Zettacandela = new ("zettacandela", "Zcd", Exacandela, 1000,0);
    public static readonly LuminousIntensity Yottacandela = new ("yottacandela", "Ycd", Zettacandela, 1000,0);
    public static readonly LuminousIntensity Ronnacandela = new ("ronnacandela", "Rcd", Yottacandela, 1000,0);
    public static readonly LuminousIntensity Quettacandela = new ("quettacandela", "Qcd", Ronnacandela, 1000,0);
}