using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Radioactive Decay.
/// </summary>
public class RadioactiveDecays : Enumeration<RadioactiveDecays,RadioactiveDecay>
{
    public static readonly RadioactiveDecay Becquerel = new ("becquerel", "Bq");
    public static readonly RadioactiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0/10.0,0);
    public static readonly RadioactiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0/10.0,0);
    public static readonly RadioactiveDecay Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0/10.0,0);
    public static readonly RadioactiveDecay Microbecquerel = new ("microbecquerel", "μBq", Millibecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Femtobecquerel = new ("femtobecquerel", "fBq", Picobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Zeptobecquerel = new ("zeptobecquerel", "zBq", Attobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Yoctobecquerel = new ("yoctobecquerel", "yBq", Zeptobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Rontobecquerel = new ("rontobecquerel", "rBq", Yoctobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Quectobecquerel = new ("quectobecquerel", "qBq", Rontobecquerel, 1.0/1000.0,0);
    public static readonly RadioactiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10,0);
    public static readonly RadioactiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10,0);
    public static readonly RadioactiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10,0);
    public static readonly RadioactiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000,0);
    public static readonly RadioactiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000,0);
    public static readonly RadioactiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000,0);
    public static readonly RadioactiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000,0);
    public static readonly RadioactiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000,0);
    public static readonly RadioactiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000,0);
    public static readonly RadioactiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000,0);
    public static readonly RadioactiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000,0);
    public static readonly RadioactiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000,0);
}