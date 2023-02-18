using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Electrical Potential.
/// </summary>
public class ElectricalPotentials : Enumeration<ElectricalPotentials,ElectricalPotential>
{
    public static readonly ElectricalPotential Volt = new ("volt", "V");
    public static readonly ElectricalPotential Decivolt = new ("decivolt", "dV", Volt, 1.0/10.0,0);
    public static readonly ElectricalPotential Centivolt = new ("centivolt", "cV", Decivolt, 1.0/10.0,0);
    public static readonly ElectricalPotential Millivolt = new ("millivolt", "mV", Centivolt, 1.0/10.0,0);
    public static readonly ElectricalPotential Microvolt = new ("microvolt", "μV", Millivolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Nanovolt = new ("nanovolt", "nV", Microvolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Picovolt = new ("picovolt", "pV", Nanovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Femtovolt = new ("femtovolt", "fV", Picovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Attovolt = new ("attovolt", "aV", Femtovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Zeptovolt = new ("zeptovolt", "zV", Attovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Yoctovolt = new ("yoctovolt", "yV", Zeptovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Rontovolt = new ("rontovolt", "rV", Yoctovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Quectovolt = new ("quectovolt", "qV", Rontovolt, 1.0/1000.0,0);
    public static readonly ElectricalPotential Dekavolt = new ("dekavolt", "daV", Volt, 10,0);
    public static readonly ElectricalPotential Hectovolt = new ("hectovolt", "hV", Dekavolt, 10,0);
    public static readonly ElectricalPotential Kilovolt = new ("kilovolt", "kV", Hectovolt, 10,0);
    public static readonly ElectricalPotential Megavolt = new ("megavolt", "MV", Kilovolt, 1000,0);
    public static readonly ElectricalPotential Gigavolt = new ("gigavolt", "GV", Megavolt, 1000,0);
    public static readonly ElectricalPotential Teravolt = new ("teravolt", "TV", Gigavolt, 1000,0);
    public static readonly ElectricalPotential Petavolt = new ("petavolt", "PV", Teravolt, 1000,0);
    public static readonly ElectricalPotential Exavolt = new ("exavolt", "EV", Petavolt, 1000,0);
    public static readonly ElectricalPotential Zettavolt = new ("zettavolt", "ZV", Exavolt, 1000,0);
    public static readonly ElectricalPotential Yottavolt = new ("yottavolt", "YV", Zettavolt, 1000,0);
    public static readonly ElectricalPotential Ronnavolt = new ("ronnavolt", "RV", Yottavolt, 1000,0);
    public static readonly ElectricalPotential Quettavolt = new ("quettavolt", "QV", Ronnavolt, 1000,0);
}