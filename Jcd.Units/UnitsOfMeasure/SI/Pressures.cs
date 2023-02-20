using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Pressure.
/// </summary>
public class Pressures : Enumeration<Pressures,Pressure>
{

    /// <summary>
    /// A(n) pascal.
    /// </summary>
    public static readonly Pressure Pascal = new ("pascal", "Pa");

    /// <summary>
    /// A(n) decipascal. Defined in terms of a(n) pascal.
    /// </summary>
    public static readonly Pressure Decipascal = new ("decipascal", "dPa", Pascal, 1.0/10.0,0);

    /// <summary>
    /// A(n) centipascal. Defined in terms of a(n) decipascal.
    /// </summary>
    public static readonly Pressure Centipascal = new ("centipascal", "cPa", Decipascal, 1.0/10.0,0);

    /// <summary>
    /// A(n) millipascal. Defined in terms of a(n) centipascal.
    /// </summary>
    public static readonly Pressure Millipascal = new ("millipascal", "mPa", Centipascal, 1.0/10.0,0);

    /// <summary>
    /// A(n) micropascal. Defined in terms of a(n) millipascal.
    /// </summary>
    public static readonly Pressure Micropascal = new ("micropascal", "μPa", Millipascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanopascal. Defined in terms of a(n) micropascal.
    /// </summary>
    public static readonly Pressure Nanopascal = new ("nanopascal", "nPa", Micropascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picopascal. Defined in terms of a(n) nanopascal.
    /// </summary>
    public static readonly Pressure Picopascal = new ("picopascal", "pPa", Nanopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtopascal. Defined in terms of a(n) picopascal.
    /// </summary>
    public static readonly Pressure Femtopascal = new ("femtopascal", "fPa", Picopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attopascal. Defined in terms of a(n) femtopascal.
    /// </summary>
    public static readonly Pressure Attopascal = new ("attopascal", "aPa", Femtopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptopascal. Defined in terms of a(n) attopascal.
    /// </summary>
    public static readonly Pressure Zeptopascal = new ("zeptopascal", "zPa", Attopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctopascal. Defined in terms of a(n) zeptopascal.
    /// </summary>
    public static readonly Pressure Yoctopascal = new ("yoctopascal", "yPa", Zeptopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontopascal. Defined in terms of a(n) yoctopascal.
    /// </summary>
    public static readonly Pressure Rontopascal = new ("rontopascal", "rPa", Yoctopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectopascal. Defined in terms of a(n) rontopascal.
    /// </summary>
    public static readonly Pressure Quectopascal = new ("quectopascal", "qPa", Rontopascal, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekapascal. Defined in terms of a(n) pascal.
    /// </summary>
    public static readonly Pressure Dekapascal = new ("dekapascal", "daPa", Pascal, 10,0);

    /// <summary>
    /// A(n) hectopascal. Defined in terms of a(n) dekapascal.
    /// </summary>
    public static readonly Pressure Hectopascal = new ("hectopascal", "hPa", Dekapascal, 10,0);

    /// <summary>
    /// A(n) kilopascal. Defined in terms of a(n) hectopascal.
    /// </summary>
    public static readonly Pressure Kilopascal = new ("kilopascal", "kPa", Hectopascal, 10,0);

    /// <summary>
    /// A(n) megapascal. Defined in terms of a(n) kilopascal.
    /// </summary>
    public static readonly Pressure Megapascal = new ("megapascal", "MPa", Kilopascal, 1000,0);

    /// <summary>
    /// A(n) gigapascal. Defined in terms of a(n) megapascal.
    /// </summary>
    public static readonly Pressure Gigapascal = new ("gigapascal", "GPa", Megapascal, 1000,0);

    /// <summary>
    /// A(n) terapascal. Defined in terms of a(n) gigapascal.
    /// </summary>
    public static readonly Pressure Terapascal = new ("terapascal", "TPa", Gigapascal, 1000,0);

    /// <summary>
    /// A(n) petapascal. Defined in terms of a(n) terapascal.
    /// </summary>
    public static readonly Pressure Petapascal = new ("petapascal", "PPa", Terapascal, 1000,0);

    /// <summary>
    /// A(n) exapascal. Defined in terms of a(n) petapascal.
    /// </summary>
    public static readonly Pressure Exapascal = new ("exapascal", "EPa", Petapascal, 1000,0);

    /// <summary>
    /// A(n) zettapascal. Defined in terms of a(n) exapascal.
    /// </summary>
    public static readonly Pressure Zettapascal = new ("zettapascal", "ZPa", Exapascal, 1000,0);

    /// <summary>
    /// A(n) yottapascal. Defined in terms of a(n) zettapascal.
    /// </summary>
    public static readonly Pressure Yottapascal = new ("yottapascal", "YPa", Zettapascal, 1000,0);

    /// <summary>
    /// A(n) ronnapascal. Defined in terms of a(n) yottapascal.
    /// </summary>
    public static readonly Pressure Ronnapascal = new ("ronnapascal", "RPa", Yottapascal, 1000,0);

    /// <summary>
    /// A(n) quettapascal. Defined in terms of a(n) ronnapascal.
    /// </summary>
    public static readonly Pressure Quettapascal = new ("quettapascal", "QPa", Ronnapascal, 1000,0);

}