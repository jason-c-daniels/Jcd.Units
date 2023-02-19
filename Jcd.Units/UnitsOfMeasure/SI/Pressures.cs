using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Pressure.
/// </summary>
public class Pressures : Enumeration<Pressures,Pressure>
{

    /// <summary>
    /// Units of a pascal.
    /// </summary>
    public static readonly Pressure Pascal = new ("pascal", "Pa");
    /// <summary>
    /// Units of a decipascal. It's defined in terms of a(n) SI pascal.
    /// </summary>
    public static readonly Pressure Decipascal = new ("decipascal", "dPa", Pascal, 1.0/10.0,0);
    /// <summary>
    /// Units of a centipascal. It's defined in terms of a(n) SI decipascal.
    /// </summary>
    public static readonly Pressure Centipascal = new ("centipascal", "cPa", Decipascal, 1.0/10.0,0);
    /// <summary>
    /// Units of a millipascal. It's defined in terms of a(n) SI centipascal.
    /// </summary>
    public static readonly Pressure Millipascal = new ("millipascal", "mPa", Centipascal, 1.0/10.0,0);
    /// <summary>
    /// Units of a micropascal. It's defined in terms of a(n) SI millipascal.
    /// </summary>
    public static readonly Pressure Micropascal = new ("micropascal", "μPa", Millipascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanopascal. It's defined in terms of a(n) SI micropascal.
    /// </summary>
    public static readonly Pressure Nanopascal = new ("nanopascal", "nPa", Micropascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picopascal. It's defined in terms of a(n) SI nanopascal.
    /// </summary>
    public static readonly Pressure Picopascal = new ("picopascal", "pPa", Nanopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtopascal. It's defined in terms of a(n) SI picopascal.
    /// </summary>
    public static readonly Pressure Femtopascal = new ("femtopascal", "fPa", Picopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attopascal. It's defined in terms of a(n) SI femtopascal.
    /// </summary>
    public static readonly Pressure Attopascal = new ("attopascal", "aPa", Femtopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptopascal. It's defined in terms of a(n) SI attopascal.
    /// </summary>
    public static readonly Pressure Zeptopascal = new ("zeptopascal", "zPa", Attopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctopascal. It's defined in terms of a(n) SI zeptopascal.
    /// </summary>
    public static readonly Pressure Yoctopascal = new ("yoctopascal", "yPa", Zeptopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontopascal. It's defined in terms of a(n) SI yoctopascal.
    /// </summary>
    public static readonly Pressure Rontopascal = new ("rontopascal", "rPa", Yoctopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectopascal. It's defined in terms of a(n) SI rontopascal.
    /// </summary>
    public static readonly Pressure Quectopascal = new ("quectopascal", "qPa", Rontopascal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekapascal. It's defined in terms of a(n) SI pascal.
    /// </summary>
    public static readonly Pressure Dekapascal = new ("dekapascal", "daPa", Pascal, 10,0);
    /// <summary>
    /// Units of a hectopascal. It's defined in terms of a(n) SI dekapascal.
    /// </summary>
    public static readonly Pressure Hectopascal = new ("hectopascal", "hPa", Dekapascal, 10,0);
    /// <summary>
    /// Units of a kilopascal. It's defined in terms of a(n) SI hectopascal.
    /// </summary>
    public static readonly Pressure Kilopascal = new ("kilopascal", "kPa", Hectopascal, 10,0);
    /// <summary>
    /// Units of a megapascal. It's defined in terms of a(n) SI kilopascal.
    /// </summary>
    public static readonly Pressure Megapascal = new ("megapascal", "MPa", Kilopascal, 1000,0);
    /// <summary>
    /// Units of a gigapascal. It's defined in terms of a(n) SI megapascal.
    /// </summary>
    public static readonly Pressure Gigapascal = new ("gigapascal", "GPa", Megapascal, 1000,0);
    /// <summary>
    /// Units of a terapascal. It's defined in terms of a(n) SI gigapascal.
    /// </summary>
    public static readonly Pressure Terapascal = new ("terapascal", "TPa", Gigapascal, 1000,0);
    /// <summary>
    /// Units of a petapascal. It's defined in terms of a(n) SI terapascal.
    /// </summary>
    public static readonly Pressure Petapascal = new ("petapascal", "PPa", Terapascal, 1000,0);
    /// <summary>
    /// Units of a exapascal. It's defined in terms of a(n) SI petapascal.
    /// </summary>
    public static readonly Pressure Exapascal = new ("exapascal", "EPa", Petapascal, 1000,0);
    /// <summary>
    /// Units of a zettapascal. It's defined in terms of a(n) SI exapascal.
    /// </summary>
    public static readonly Pressure Zettapascal = new ("zettapascal", "ZPa", Exapascal, 1000,0);
    /// <summary>
    /// Units of a yottapascal. It's defined in terms of a(n) SI zettapascal.
    /// </summary>
    public static readonly Pressure Yottapascal = new ("yottapascal", "YPa", Zettapascal, 1000,0);
    /// <summary>
    /// Units of a ronnapascal. It's defined in terms of a(n) SI yottapascal.
    /// </summary>
    public static readonly Pressure Ronnapascal = new ("ronnapascal", "RPa", Yottapascal, 1000,0);
    /// <summary>
    /// Units of a quettapascal. It's defined in terms of a(n) SI ronnapascal.
    /// </summary>
    public static readonly Pressure Quettapascal = new ("quettapascal", "QPa", Ronnapascal, 1000,0);

}