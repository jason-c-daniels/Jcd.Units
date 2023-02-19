using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Potential.
/// </summary>
public class ElectricalPotentials : Enumeration<ElectricalPotentials,ElectricalPotential>
{


    /// <summary>
    /// A(n) volt.
    /// </summary>
    public static readonly ElectricalPotential Volt = new ("volt", "V");
    /// <summary>
    /// A(n) decivolt. It's defined in terms of a(n) volt.
    /// </summary>
    public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centivolt. It's defined in terms of a(n) decivolt.
    /// </summary>
    public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millivolt. It's defined in terms of a(n) centivolt.
    /// </summary>
    public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microvolt. It's defined in terms of a(n) millivolt.
    /// </summary>
    public static readonly ElectricalPotential Microvolt = new ("microvolt", "μV", Millivolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanovolt. It's defined in terms of a(n) microvolt.
    /// </summary>
    public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picovolt. It's defined in terms of a(n) nanovolt.
    /// </summary>
    public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtovolt. It's defined in terms of a(n) picovolt.
    /// </summary>
    public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attovolt. It's defined in terms of a(n) femtovolt.
    /// </summary>
    public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptovolt. It's defined in terms of a(n) attovolt.
    /// </summary>
    public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctovolt. It's defined in terms of a(n) zeptovolt.
    /// </summary>
    public static readonly ElectricalPotential Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontovolt. It's defined in terms of a(n) yoctovolt.
    /// </summary>
    public static readonly ElectricalPotential Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectovolt. It's defined in terms of a(n) rontovolt.
    /// </summary>
    public static readonly ElectricalPotential Quectovolt = new ("quectovolt", "qV", Rontovolt, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekavolt. It's defined in terms of a(n) volt.
    /// </summary>
    public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10,0);
    
    /// <summary>
    /// A(n) hectovolt. It's defined in terms of a(n) dekavolt.
    /// </summary>
    public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10,0);
    
    /// <summary>
    /// A(n) kilovolt. It's defined in terms of a(n) hectovolt.
    /// </summary>
    public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10,0);
    
    /// <summary>
    /// A(n) megavolt. It's defined in terms of a(n) kilovolt.
    /// </summary>
    public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000,0);
    
    /// <summary>
    /// A(n) gigavolt. It's defined in terms of a(n) megavolt.
    /// </summary>
    public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000,0);
    
    /// <summary>
    /// A(n) teravolt. It's defined in terms of a(n) gigavolt.
    /// </summary>
    public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000,0);
    
    /// <summary>
    /// A(n) petavolt. It's defined in terms of a(n) teravolt.
    /// </summary>
    public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000,0);
    
    /// <summary>
    /// A(n) exavolt. It's defined in terms of a(n) petavolt.
    /// </summary>
    public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000,0);
    
    /// <summary>
    /// A(n) zettavolt. It's defined in terms of a(n) exavolt.
    /// </summary>
    public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000,0);
    
    /// <summary>
    /// A(n) yottavolt. It's defined in terms of a(n) zettavolt.
    /// </summary>
    public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000,0);
    
    /// <summary>
    /// A(n) ronnavolt. It's defined in terms of a(n) yottavolt.
    /// </summary>
    public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000,0);
    
    /// <summary>
    /// A(n) quettavolt. It's defined in terms of a(n) ronnavolt.
    /// </summary>
    public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000,0);

}