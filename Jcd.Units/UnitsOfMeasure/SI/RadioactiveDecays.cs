using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class RadioactiveDecays : Enumeration<RadioactiveDecays,RadioActiveDecay>
{
    public static readonly RadioActiveDecay Becquerel = new ("becquerel", "Bq");
    public static readonly RadioActiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0/10.0,0);
    public static readonly RadioActiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0/10.0,0);
    public static readonly RadioActiveDecay Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0/10.0,0);
    public static readonly RadioActiveDecay Microbecquerel = new ("microbecquerel", "μBq", Millibecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Femtobecquerel = new ("femtobecquerel", "fBq", Picobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Zeptobecquerel = new ("zeptobecquerel", "zBq", Attobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Yoctobecquerel = new ("yoctobecquerel", "yBq", Zeptobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Rontobecquerel = new ("rontobecquerel", "rBq", Yoctobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Quectobecquerel = new ("quectobecquerel", "qBq", Rontobecquerel, 1.0/1000.0,0);
    public static readonly RadioActiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10,0);
    public static readonly RadioActiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10,0);
    public static readonly RadioActiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10,0);
    public static readonly RadioActiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000,0);
    public static readonly RadioActiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000,0);
    public static readonly RadioActiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000,0);
    public static readonly RadioActiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000,0);
    public static readonly RadioActiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000,0);
    public static readonly RadioActiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000,0);
    public static readonly RadioActiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000,0);
    public static readonly RadioActiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000,0);
    public static readonly RadioActiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000,0);
}