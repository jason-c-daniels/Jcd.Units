using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Power.
/// </summary>
public class Powers : Enumeration<Powers,Power>
{

    /// <summary>
    /// Units of a watt.
    /// </summary>
    public static readonly Power Watt = new ("watt", "W");
    /// <summary>
    /// Units of a deciwatt. It's defined in terms of a(n) SI watt.
    /// </summary>
    public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0/10.0,0);
    /// <summary>
    /// Units of a centiwatt. It's defined in terms of a(n) SI deciwatt.
    /// </summary>
    public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0/10.0,0);
    /// <summary>
    /// Units of a milliwatt. It's defined in terms of a(n) SI centiwatt.
    /// </summary>
    public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0/10.0,0);
    /// <summary>
    /// Units of a microwatt. It's defined in terms of a(n) SI milliwatt.
    /// </summary>
    public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanowatt. It's defined in terms of a(n) SI microwatt.
    /// </summary>
    public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picowatt. It's defined in terms of a(n) SI nanowatt.
    /// </summary>
    public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtowatt. It's defined in terms of a(n) SI picowatt.
    /// </summary>
    public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attowatt. It's defined in terms of a(n) SI femtowatt.
    /// </summary>
    public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptowatt. It's defined in terms of a(n) SI attowatt.
    /// </summary>
    public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctowatt. It's defined in terms of a(n) SI zeptowatt.
    /// </summary>
    public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontowatt. It's defined in terms of a(n) SI yoctowatt.
    /// </summary>
    public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectowatt. It's defined in terms of a(n) SI rontowatt.
    /// </summary>
    public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekawatt. It's defined in terms of a(n) SI watt.
    /// </summary>
    public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10,0);
    /// <summary>
    /// Units of a hectowatt. It's defined in terms of a(n) SI dekawatt.
    /// </summary>
    public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10,0);
    /// <summary>
    /// Units of a kilowatt. It's defined in terms of a(n) SI hectowatt.
    /// </summary>
    public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10,0);
    /// <summary>
    /// Units of a megawatt. It's defined in terms of a(n) SI kilowatt.
    /// </summary>
    public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000,0);
    /// <summary>
    /// Units of a gigawatt. It's defined in terms of a(n) SI megawatt.
    /// </summary>
    public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000,0);
    /// <summary>
    /// Units of a terawatt. It's defined in terms of a(n) SI gigawatt.
    /// </summary>
    public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000,0);
    /// <summary>
    /// Units of a petawatt. It's defined in terms of a(n) SI terawatt.
    /// </summary>
    public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000,0);
    /// <summary>
    /// Units of a exawatt. It's defined in terms of a(n) SI petawatt.
    /// </summary>
    public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000,0);
    /// <summary>
    /// Units of a zettawatt. It's defined in terms of a(n) SI exawatt.
    /// </summary>
    public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000,0);
    /// <summary>
    /// Units of a yottawatt. It's defined in terms of a(n) SI zettawatt.
    /// </summary>
    public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000,0);
    /// <summary>
    /// Units of a ronnawatt. It's defined in terms of a(n) SI yottawatt.
    /// </summary>
    public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000,0);
    /// <summary>
    /// Units of a quettawatt. It's defined in terms of a(n) SI ronnawatt.
    /// </summary>
    public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000,0);

}