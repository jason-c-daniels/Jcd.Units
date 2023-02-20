using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global


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
    /// A(n) decivolt. Defined in terms of a(n) volt.
    /// </summary>
    public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0/10.0,0);

    /// <summary>
    /// A(n) centivolt. Defined in terms of a(n) decivolt.
    /// </summary>
    public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0/10.0,0);

    /// <summary>
    /// A(n) millivolt. Defined in terms of a(n) centivolt.
    /// </summary>
    public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0/10.0,0);

    /// <summary>
    /// A(n) microvolt. Defined in terms of a(n) millivolt.
    /// </summary>
    public static readonly ElectricalPotential Microvolt = new ("microvolt", "μV", Millivolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanovolt. Defined in terms of a(n) microvolt.
    /// </summary>
    public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picovolt. Defined in terms of a(n) nanovolt.
    /// </summary>
    public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtovolt. Defined in terms of a(n) picovolt.
    /// </summary>
    public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attovolt. Defined in terms of a(n) femtovolt.
    /// </summary>
    public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptovolt. Defined in terms of a(n) attovolt.
    /// </summary>
    public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctovolt. Defined in terms of a(n) zeptovolt.
    /// </summary>
    public static readonly ElectricalPotential Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontovolt. Defined in terms of a(n) yoctovolt.
    /// </summary>
    public static readonly ElectricalPotential Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectovolt. Defined in terms of a(n) rontovolt.
    /// </summary>
    public static readonly ElectricalPotential Quectovolt = new ("quectovolt", "qV", Rontovolt, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekavolt. Defined in terms of a(n) volt.
    /// </summary>
    public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10,0);

    /// <summary>
    /// A(n) hectovolt. Defined in terms of a(n) dekavolt.
    /// </summary>
    public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10,0);

    /// <summary>
    /// A(n) kilovolt. Defined in terms of a(n) hectovolt.
    /// </summary>
    public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10,0);

    /// <summary>
    /// A(n) megavolt. Defined in terms of a(n) kilovolt.
    /// </summary>
    public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000,0);

    /// <summary>
    /// A(n) gigavolt. Defined in terms of a(n) megavolt.
    /// </summary>
    public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000,0);

    /// <summary>
    /// A(n) teravolt. Defined in terms of a(n) gigavolt.
    /// </summary>
    public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000,0);

    /// <summary>
    /// A(n) petavolt. Defined in terms of a(n) teravolt.
    /// </summary>
    public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000,0);

    /// <summary>
    /// A(n) exavolt. Defined in terms of a(n) petavolt.
    /// </summary>
    public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000,0);

    /// <summary>
    /// A(n) zettavolt. Defined in terms of a(n) exavolt.
    /// </summary>
    public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000,0);

    /// <summary>
    /// A(n) yottavolt. Defined in terms of a(n) zettavolt.
    /// </summary>
    public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000,0);

    /// <summary>
    /// A(n) ronnavolt. Defined in terms of a(n) yottavolt.
    /// </summary>
    public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000,0);

    /// <summary>
    /// A(n) quettavolt. Defined in terms of a(n) ronnavolt.
    /// </summary>
    public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000,0);

}