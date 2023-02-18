using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Powers : Enumeration<Powers,Power>
{
    public static readonly Power Watt = new ("watt", "W");
    public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0/10.0,0);
    public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0/10.0,0);
    public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0/10.0,0);
    public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0/1000.0,0);
    public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0/1000.0,0);
    public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0/1000.0,0);
    public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0/1000.0,0);
    public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0/1000.0,0);
    public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0/1000.0,0);
    public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0/1000.0,0);
    public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0/1000.0,0);
    public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0/1000.0,0);
    public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10,0);
    public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10,0);
    public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10,0);
    public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000,0);
    public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000,0);
    public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000,0);
    public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000,0);
    public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000,0);
    public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000,0);
    public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000,0);
    public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000,0);
    public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000,0);
}