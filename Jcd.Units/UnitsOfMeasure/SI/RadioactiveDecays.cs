using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radioactive Decay.
/// </summary>
public class RadioactiveDecays : Enumeration<RadioactiveDecays,RadioactiveDecay>
{


    /// <summary>
    /// A(n) becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Becquerel = new ("becquerel", "Bq");
    /// <summary>
    /// A(n) decibecquerel. It's defined in terms of a(n) becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centibecquerel. It's defined in terms of a(n) decibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millibecquerel. It's defined in terms of a(n) centibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microbecquerel. It's defined in terms of a(n) millibecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Microbecquerel = new ("microbecquerel", "μBq", Millibecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanobecquerel. It's defined in terms of a(n) microbecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picobecquerel. It's defined in terms of a(n) nanobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtobecquerel. It's defined in terms of a(n) picobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Femtobecquerel = new ("femtobecquerel", "fBq", Picobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attobecquerel. It's defined in terms of a(n) femtobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptobecquerel. It's defined in terms of a(n) attobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Zeptobecquerel = new ("zeptobecquerel", "zBq", Attobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctobecquerel. It's defined in terms of a(n) zeptobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Yoctobecquerel = new ("yoctobecquerel", "yBq", Zeptobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontobecquerel. It's defined in terms of a(n) yoctobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Rontobecquerel = new ("rontobecquerel", "rBq", Yoctobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectobecquerel. It's defined in terms of a(n) rontobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Quectobecquerel = new ("quectobecquerel", "qBq", Rontobecquerel, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekabecquerel. It's defined in terms of a(n) becquerel.
    /// </summary>
    public static readonly RadioactiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10,0);
    
    /// <summary>
    /// A(n) hectobecquerel. It's defined in terms of a(n) dekabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10,0);
    
    /// <summary>
    /// A(n) kilobecquerel. It's defined in terms of a(n) hectobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10,0);
    
    /// <summary>
    /// A(n) megabecquerel. It's defined in terms of a(n) kilobecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000,0);
    
    /// <summary>
    /// A(n) gigabecquerel. It's defined in terms of a(n) megabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) terabecquerel. It's defined in terms of a(n) gigabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) petabecquerel. It's defined in terms of a(n) terabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) exabecquerel. It's defined in terms of a(n) petabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) zettabecquerel. It's defined in terms of a(n) exabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) yottabecquerel. It's defined in terms of a(n) zettabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) ronnabecquerel. It's defined in terms of a(n) yottabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000,0);
    
    /// <summary>
    /// A(n) quettabecquerel. It's defined in terms of a(n) ronnabecquerel.
    /// </summary>
    public static readonly RadioactiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000,0);

}