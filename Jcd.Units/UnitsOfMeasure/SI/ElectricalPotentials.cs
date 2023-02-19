using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Potential.
/// </summary>
public class ElectricalPotentials : Enumeration<ElectricalPotentials,ElectricalPotential>
{

    /// <summary>
    /// Units of a volt.
    /// </summary>
    public static readonly ElectricalPotential Volt = new ("volt", "V");
    /// <summary>
    /// Units of a decivolt. It's defined in terms of a(n) SI volt.
    /// </summary>
    public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0/10.0,0);
    /// <summary>
    /// Units of a centivolt. It's defined in terms of a(n) SI decivolt.
    /// </summary>
    public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0/10.0,0);
    /// <summary>
    /// Units of a millivolt. It's defined in terms of a(n) SI centivolt.
    /// </summary>
    public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0/10.0,0);
    /// <summary>
    /// Units of a microvolt. It's defined in terms of a(n) SI millivolt.
    /// </summary>
    public static readonly ElectricalPotential Microvolt = new ("microvolt", "μV", Millivolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanovolt. It's defined in terms of a(n) SI microvolt.
    /// </summary>
    public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picovolt. It's defined in terms of a(n) SI nanovolt.
    /// </summary>
    public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtovolt. It's defined in terms of a(n) SI picovolt.
    /// </summary>
    public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attovolt. It's defined in terms of a(n) SI femtovolt.
    /// </summary>
    public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptovolt. It's defined in terms of a(n) SI attovolt.
    /// </summary>
    public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctovolt. It's defined in terms of a(n) SI zeptovolt.
    /// </summary>
    public static readonly ElectricalPotential Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontovolt. It's defined in terms of a(n) SI yoctovolt.
    /// </summary>
    public static readonly ElectricalPotential Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectovolt. It's defined in terms of a(n) SI rontovolt.
    /// </summary>
    public static readonly ElectricalPotential Quectovolt = new ("quectovolt", "qV", Rontovolt, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekavolt. It's defined in terms of a(n) SI volt.
    /// </summary>
    public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10,0);
    /// <summary>
    /// Units of a hectovolt. It's defined in terms of a(n) SI dekavolt.
    /// </summary>
    public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10,0);
    /// <summary>
    /// Units of a kilovolt. It's defined in terms of a(n) SI hectovolt.
    /// </summary>
    public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10,0);
    /// <summary>
    /// Units of a megavolt. It's defined in terms of a(n) SI kilovolt.
    /// </summary>
    public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000,0);
    /// <summary>
    /// Units of a gigavolt. It's defined in terms of a(n) SI megavolt.
    /// </summary>
    public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000,0);
    /// <summary>
    /// Units of a teravolt. It's defined in terms of a(n) SI gigavolt.
    /// </summary>
    public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000,0);
    /// <summary>
    /// Units of a petavolt. It's defined in terms of a(n) SI teravolt.
    /// </summary>
    public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000,0);
    /// <summary>
    /// Units of a exavolt. It's defined in terms of a(n) SI petavolt.
    /// </summary>
    public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000,0);
    /// <summary>
    /// Units of a zettavolt. It's defined in terms of a(n) SI exavolt.
    /// </summary>
    public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000,0);
    /// <summary>
    /// Units of a yottavolt. It's defined in terms of a(n) SI zettavolt.
    /// </summary>
    public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000,0);
    /// <summary>
    /// Units of a ronnavolt. It's defined in terms of a(n) SI yottavolt.
    /// </summary>
    public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000,0);
    /// <summary>
    /// Units of a quettavolt. It's defined in terms of a(n) SI ronnavolt.
    /// </summary>
    public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000,0);

}