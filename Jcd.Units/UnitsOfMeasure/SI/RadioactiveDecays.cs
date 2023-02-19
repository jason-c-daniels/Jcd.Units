using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radioactive Decay.
/// </summary>
public class RadioactiveDecays : Enumeration<RadioactiveDecays,RadioactiveDecay>
{

    /// <summary>
    /// Units of a becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Becquerel = new ("becquerel", "Bq");
    /// <summary>
    /// Units of a decibecquerel. It's defined in terms of a(n) SI becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0/10.0,0);
    /// <summary>
    /// Units of a centibecquerel. It's defined in terms of a(n) SI decibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0/10.0,0);
    /// <summary>
    /// Units of a millibecquerel. It's defined in terms of a(n) SI centibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0/10.0,0);
    /// <summary>
    /// Units of a microbecquerel. It's defined in terms of a(n) SI millibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Microbecquerel = new ("microbecquerel", "μBq", Millibecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanobecquerel. It's defined in terms of a(n) SI microbecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picobecquerel. It's defined in terms of a(n) SI nanobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtobecquerel. It's defined in terms of a(n) SI picobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Femtobecquerel = new ("femtobecquerel", "fBq", Picobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attobecquerel. It's defined in terms of a(n) SI femtobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptobecquerel. It's defined in terms of a(n) SI attobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Zeptobecquerel = new ("zeptobecquerel", "zBq", Attobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctobecquerel. It's defined in terms of a(n) SI zeptobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Yoctobecquerel = new ("yoctobecquerel", "yBq", Zeptobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontobecquerel. It's defined in terms of a(n) SI yoctobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Rontobecquerel = new ("rontobecquerel", "rBq", Yoctobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectobecquerel. It's defined in terms of a(n) SI rontobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Quectobecquerel = new ("quectobecquerel", "qBq", Rontobecquerel, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekabecquerel. It's defined in terms of a(n) SI becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10,0);
    /// <summary>
    /// Units of a hectobecquerel. It's defined in terms of a(n) SI dekabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10,0);
    /// <summary>
    /// Units of a kilobecquerel. It's defined in terms of a(n) SI hectobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10,0);
    /// <summary>
    /// Units of a megabecquerel. It's defined in terms of a(n) SI kilobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000,0);
    /// <summary>
    /// Units of a gigabecquerel. It's defined in terms of a(n) SI megabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000,0);
    /// <summary>
    /// Units of a terabecquerel. It's defined in terms of a(n) SI gigabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000,0);
    /// <summary>
    /// Units of a petabecquerel. It's defined in terms of a(n) SI terabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000,0);
    /// <summary>
    /// Units of a exabecquerel. It's defined in terms of a(n) SI petabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000,0);
    /// <summary>
    /// Units of a zettabecquerel. It's defined in terms of a(n) SI exabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000,0);
    /// <summary>
    /// Units of a yottabecquerel. It's defined in terms of a(n) SI zettabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000,0);
    /// <summary>
    /// Units of a ronnabecquerel. It's defined in terms of a(n) SI yottabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000,0);
    /// <summary>
    /// Units of a quettabecquerel. It's defined in terms of a(n) SI ronnabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000,0);

}