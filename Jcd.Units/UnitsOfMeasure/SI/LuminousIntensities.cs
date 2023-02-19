using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Luminous Intensity.
/// </summary>
public class LuminousIntensities : Enumeration<LuminousIntensities,LuminousIntensity>
{

    /// <summary>
    /// Units of a candela.
    /// </summary>
    public static readonly LuminousIntensity Candela = new ("candela", "cd");
    /// <summary>
    /// Units of a decicandela. It's defined in terms of a(n) SI candela.
    /// </summary>
    public static readonly LuminousIntensity Decicandela = new ("decicandela", "dcd", Candela, 1.0/10.0,0);
    /// <summary>
    /// Units of a centicandela. It's defined in terms of a(n) SI decicandela.
    /// </summary>
    public static readonly LuminousIntensity Centicandela = new ("centicandela", "ccd", Decicandela, 1.0/10.0,0);
    /// <summary>
    /// Units of a millicandela. It's defined in terms of a(n) SI centicandela.
    /// </summary>
    public static readonly LuminousIntensity Millicandela = new ("millicandela", "mcd", Centicandela, 1.0/10.0,0);
    /// <summary>
    /// Units of a microcandela. It's defined in terms of a(n) SI millicandela.
    /// </summary>
    public static readonly LuminousIntensity Microcandela = new ("microcandela", "μcd", Millicandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanocandela. It's defined in terms of a(n) SI microcandela.
    /// </summary>
    public static readonly LuminousIntensity Nanocandela = new ("nanocandela", "ncd", Microcandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picocandela. It's defined in terms of a(n) SI nanocandela.
    /// </summary>
    public static readonly LuminousIntensity Picocandela = new ("picocandela", "pcd", Nanocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtocandela. It's defined in terms of a(n) SI picocandela.
    /// </summary>
    public static readonly LuminousIntensity Femtocandela = new ("femtocandela", "fcd", Picocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attocandela. It's defined in terms of a(n) SI femtocandela.
    /// </summary>
    public static readonly LuminousIntensity Attocandela = new ("attocandela", "acd", Femtocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptocandela. It's defined in terms of a(n) SI attocandela.
    /// </summary>
    public static readonly LuminousIntensity Zeptocandela = new ("zeptocandela", "zcd", Attocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctocandela. It's defined in terms of a(n) SI zeptocandela.
    /// </summary>
    public static readonly LuminousIntensity Yoctocandela = new ("yoctocandela", "ycd", Zeptocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontocandela. It's defined in terms of a(n) SI yoctocandela.
    /// </summary>
    public static readonly LuminousIntensity Rontocandela = new ("rontocandela", "rcd", Yoctocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectocandela. It's defined in terms of a(n) SI rontocandela.
    /// </summary>
    public static readonly LuminousIntensity Quectocandela = new ("quectocandela", "qcd", Rontocandela, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekacandela. It's defined in terms of a(n) SI candela.
    /// </summary>
    public static readonly LuminousIntensity Dekacandela = new ("dekacandela", "dacd", Candela, 10,0);
    /// <summary>
    /// Units of a hectocandela. It's defined in terms of a(n) SI dekacandela.
    /// </summary>
    public static readonly LuminousIntensity Hectocandela = new ("hectocandela", "hcd", Dekacandela, 10,0);
    /// <summary>
    /// Units of a kilocandela. It's defined in terms of a(n) SI hectocandela.
    /// </summary>
    public static readonly LuminousIntensity Kilocandela = new ("kilocandela", "kcd", Hectocandela, 10,0);
    /// <summary>
    /// Units of a megacandela. It's defined in terms of a(n) SI kilocandela.
    /// </summary>
    public static readonly LuminousIntensity Megacandela = new ("megacandela", "Mcd", Kilocandela, 1000,0);
    /// <summary>
    /// Units of a gigacandela. It's defined in terms of a(n) SI megacandela.
    /// </summary>
    public static readonly LuminousIntensity Gigacandela = new ("gigacandela", "Gcd", Megacandela, 1000,0);
    /// <summary>
    /// Units of a teracandela. It's defined in terms of a(n) SI gigacandela.
    /// </summary>
    public static readonly LuminousIntensity Teracandela = new ("teracandela", "Tcd", Gigacandela, 1000,0);
    /// <summary>
    /// Units of a petacandela. It's defined in terms of a(n) SI teracandela.
    /// </summary>
    public static readonly LuminousIntensity Petacandela = new ("petacandela", "Pcd", Teracandela, 1000,0);
    /// <summary>
    /// Units of a exacandela. It's defined in terms of a(n) SI petacandela.
    /// </summary>
    public static readonly LuminousIntensity Exacandela = new ("exacandela", "Ecd", Petacandela, 1000,0);
    /// <summary>
    /// Units of a zettacandela. It's defined in terms of a(n) SI exacandela.
    /// </summary>
    public static readonly LuminousIntensity Zettacandela = new ("zettacandela", "Zcd", Exacandela, 1000,0);
    /// <summary>
    /// Units of a yottacandela. It's defined in terms of a(n) SI zettacandela.
    /// </summary>
    public static readonly LuminousIntensity Yottacandela = new ("yottacandela", "Ycd", Zettacandela, 1000,0);
    /// <summary>
    /// Units of a ronnacandela. It's defined in terms of a(n) SI yottacandela.
    /// </summary>
    public static readonly LuminousIntensity Ronnacandela = new ("ronnacandela", "Rcd", Yottacandela, 1000,0);
    /// <summary>
    /// Units of a quettacandela. It's defined in terms of a(n) SI ronnacandela.
    /// </summary>
    public static readonly LuminousIntensity Quettacandela = new ("quettacandela", "Qcd", Ronnacandela, 1000,0);

}