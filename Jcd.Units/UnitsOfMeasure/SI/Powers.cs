using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Power.
/// </summary>
public class Powers : Enumeration<Powers,Power>
{


    /// <summary>
    /// A(n) watt.
    /// </summary>
    public static readonly Power Watt = new ("watt", "W");
    /// <summary>
    /// A(n) deciwatt. Defined in terms of a(n) watt.
    /// </summary>
    public static readonly Power Deciwatt = new ("deciwatt", "dW", Watt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centiwatt. Defined in terms of a(n) deciwatt.
    /// </summary>
    public static readonly Power Centiwatt = new ("centiwatt", "cW", Deciwatt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) milliwatt. Defined in terms of a(n) centiwatt.
    /// </summary>
    public static readonly Power Milliwatt = new ("milliwatt", "mW", Centiwatt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microwatt. Defined in terms of a(n) milliwatt.
    /// </summary>
    public static readonly Power Microwatt = new ("microwatt", "μW", Milliwatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanowatt. Defined in terms of a(n) microwatt.
    /// </summary>
    public static readonly Power Nanowatt = new ("nanowatt", "nW", Microwatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picowatt. Defined in terms of a(n) nanowatt.
    /// </summary>
    public static readonly Power Picowatt = new ("picowatt", "pW", Nanowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtowatt. Defined in terms of a(n) picowatt.
    /// </summary>
    public static readonly Power Femtowatt = new ("femtowatt", "fW", Picowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attowatt. Defined in terms of a(n) femtowatt.
    /// </summary>
    public static readonly Power Attowatt = new ("attowatt", "aW", Femtowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptowatt. Defined in terms of a(n) attowatt.
    /// </summary>
    public static readonly Power Zeptowatt = new ("zeptowatt", "zW", Attowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctowatt. Defined in terms of a(n) zeptowatt.
    /// </summary>
    public static readonly Power Yoctowatt = new ("yoctowatt", "yW", Zeptowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontowatt. Defined in terms of a(n) yoctowatt.
    /// </summary>
    public static readonly Power Rontowatt = new ("rontowatt", "rW", Yoctowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectowatt. Defined in terms of a(n) rontowatt.
    /// </summary>
    public static readonly Power Quectowatt = new ("quectowatt", "qW", Rontowatt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekawatt. Defined in terms of a(n) watt.
    /// </summary>
    public static readonly Power Dekawatt = new ("dekawatt", "daW", Watt, 10,0);
    
    /// <summary>
    /// A(n) hectowatt. Defined in terms of a(n) dekawatt.
    /// </summary>
    public static readonly Power Hectowatt = new ("hectowatt", "hW", Dekawatt, 10,0);
    
    /// <summary>
    /// A(n) kilowatt. Defined in terms of a(n) hectowatt.
    /// </summary>
    public static readonly Power Kilowatt = new ("kilowatt", "kW", Hectowatt, 10,0);
    
    /// <summary>
    /// A(n) megawatt. Defined in terms of a(n) kilowatt.
    /// </summary>
    public static readonly Power Megawatt = new ("megawatt", "MW", Kilowatt, 1000,0);
    
    /// <summary>
    /// A(n) gigawatt. Defined in terms of a(n) megawatt.
    /// </summary>
    public static readonly Power Gigawatt = new ("gigawatt", "GW", Megawatt, 1000,0);
    
    /// <summary>
    /// A(n) terawatt. Defined in terms of a(n) gigawatt.
    /// </summary>
    public static readonly Power Terawatt = new ("terawatt", "TW", Gigawatt, 1000,0);
    
    /// <summary>
    /// A(n) petawatt. Defined in terms of a(n) terawatt.
    /// </summary>
    public static readonly Power Petawatt = new ("petawatt", "PW", Terawatt, 1000,0);
    
    /// <summary>
    /// A(n) exawatt. Defined in terms of a(n) petawatt.
    /// </summary>
    public static readonly Power Exawatt = new ("exawatt", "EW", Petawatt, 1000,0);
    
    /// <summary>
    /// A(n) zettawatt. Defined in terms of a(n) exawatt.
    /// </summary>
    public static readonly Power Zettawatt = new ("zettawatt", "ZW", Exawatt, 1000,0);
    
    /// <summary>
    /// A(n) yottawatt. Defined in terms of a(n) zettawatt.
    /// </summary>
    public static readonly Power Yottawatt = new ("yottawatt", "YW", Zettawatt, 1000,0);
    
    /// <summary>
    /// A(n) ronnawatt. Defined in terms of a(n) yottawatt.
    /// </summary>
    public static readonly Power Ronnawatt = new ("ronnawatt", "RW", Yottawatt, 1000,0);
    
    /// <summary>
    /// A(n) quettawatt. Defined in terms of a(n) ronnawatt.
    /// </summary>
    public static readonly Power Quettawatt = new ("quettawatt", "QW", Ronnawatt, 1000,0);

}