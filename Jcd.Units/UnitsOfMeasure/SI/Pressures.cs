using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Pressure.
/// </summary>
public class Pressures : Enumeration<Pressures,Pressure>
{
    public static readonly Pressure Pascal = new ("pascal", "Pa");
    public static readonly Pressure Decipascal = new ("decipascal", "dPa", Pascal, 1.0/10.0,0);
    public static readonly Pressure Centipascal = new ("centipascal", "cPa", Decipascal, 1.0/10.0,0);
    public static readonly Pressure Millipascal = new ("millipascal", "mPa", Centipascal, 1.0/10.0,0);
    public static readonly Pressure Micropascal = new ("micropascal", "μPa", Millipascal, 1.0/1000.0,0);
    public static readonly Pressure Nanopascal = new ("nanopascal", "nPa", Micropascal, 1.0/1000.0,0);
    public static readonly Pressure Picopascal = new ("picopascal", "pPa", Nanopascal, 1.0/1000.0,0);
    public static readonly Pressure Femtopascal = new ("femtopascal", "fPa", Picopascal, 1.0/1000.0,0);
    public static readonly Pressure Attopascal = new ("attopascal", "aPa", Femtopascal, 1.0/1000.0,0);
    public static readonly Pressure Zeptopascal = new ("zeptopascal", "zPa", Attopascal, 1.0/1000.0,0);
    public static readonly Pressure Yoctopascal = new ("yoctopascal", "yPa", Zeptopascal, 1.0/1000.0,0);
    public static readonly Pressure Rontopascal = new ("rontopascal", "rPa", Yoctopascal, 1.0/1000.0,0);
    public static readonly Pressure Quectopascal = new ("quectopascal", "qPa", Rontopascal, 1.0/1000.0,0);
    public static readonly Pressure Dekapascal = new ("dekapascal", "daPa", Pascal, 10,0);
    public static readonly Pressure Hectopascal = new ("hectopascal", "hPa", Dekapascal, 10,0);
    public static readonly Pressure Kilopascal = new ("kilopascal", "kPa", Hectopascal, 10,0);
    public static readonly Pressure Megapascal = new ("megapascal", "MPa", Kilopascal, 1000,0);
    public static readonly Pressure Gigapascal = new ("gigapascal", "GPa", Megapascal, 1000,0);
    public static readonly Pressure Terapascal = new ("terapascal", "TPa", Gigapascal, 1000,0);
    public static readonly Pressure Petapascal = new ("petapascal", "PPa", Terapascal, 1000,0);
    public static readonly Pressure Exapascal = new ("exapascal", "EPa", Petapascal, 1000,0);
    public static readonly Pressure Zettapascal = new ("zettapascal", "ZPa", Exapascal, 1000,0);
    public static readonly Pressure Yottapascal = new ("yottapascal", "YPa", Zettapascal, 1000,0);
    public static readonly Pressure Ronnapascal = new ("ronnapascal", "RPa", Yottapascal, 1000,0);
    public static readonly Pressure Quettapascal = new ("quettapascal", "QPa", Ronnapascal, 1000,0);
}