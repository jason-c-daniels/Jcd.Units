using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Mass.
/// </summary>
public class Masses : Enumeration<Masses,Mass>
{

    /// <summary>
    /// A(n) gram.
    /// </summary>
    public static readonly Mass Gram = new ("gram", "g");

    /// <summary>
    /// A(n) decigram. Defined in terms of a(n) gram.
    /// </summary>
    public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0/10.0,0);

    /// <summary>
    /// A(n) centigram. Defined in terms of a(n) decigram.
    /// </summary>
    public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0/10.0,0);

    /// <summary>
    /// A(n) milligram. Defined in terms of a(n) centigram.
    /// </summary>
    public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0/10.0,0);

    /// <summary>
    /// A(n) microgram. Defined in terms of a(n) milligram.
    /// </summary>
    public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) nanogram. Defined in terms of a(n) microgram.
    /// </summary>
    public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) picogram. Defined in terms of a(n) nanogram.
    /// </summary>
    public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) femtogram. Defined in terms of a(n) picogram.
    /// </summary>
    public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) attogram. Defined in terms of a(n) femtogram.
    /// </summary>
    public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) zeptogram. Defined in terms of a(n) attogram.
    /// </summary>
    public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) yoctogram. Defined in terms of a(n) zeptogram.
    /// </summary>
    public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) rontogram. Defined in terms of a(n) yoctogram.
    /// </summary>
    public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) quectogram. Defined in terms of a(n) rontogram.
    /// </summary>
    public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0/1000.0,0);

    /// <summary>
    /// A(n) dekagram. Defined in terms of a(n) gram.
    /// </summary>
    public static readonly Mass Dekagram = new ("dekagram", "dag", Gram, 10,0);

    /// <summary>
    /// A(n) hectogram. Defined in terms of a(n) dekagram.
    /// </summary>
    public static readonly Mass Hectogram = new ("hectogram", "hg", Dekagram, 10,0);

    /// <summary>
    /// A(n) kilogram. Defined in terms of a(n) hectogram.
    /// </summary>
    public static readonly Mass Kilogram = new ("kilogram", "kg", Hectogram, 10,0);

    /// <summary>
    /// A(n) megagram. Defined in terms of a(n) kilogram.
    /// </summary>
    public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000,0);

    /// <summary>
    /// A(n) gigagram. Defined in terms of a(n) megagram.
    /// </summary>
    public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000,0);

    /// <summary>
    /// A(n) teragram. Defined in terms of a(n) gigagram.
    /// </summary>
    public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000,0);

    /// <summary>
    /// A(n) petagram. Defined in terms of a(n) teragram.
    /// </summary>
    public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000,0);

    /// <summary>
    /// A(n) exagram. Defined in terms of a(n) petagram.
    /// </summary>
    public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000,0);

    /// <summary>
    /// A(n) zettagram. Defined in terms of a(n) exagram.
    /// </summary>
    public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000,0);

    /// <summary>
    /// A(n) yottagram. Defined in terms of a(n) zettagram.
    /// </summary>
    public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000,0);

    /// <summary>
    /// A(n) ronnagram. Defined in terms of a(n) yottagram.
    /// </summary>
    public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000,0);

    /// <summary>
    /// A(n) quettagram. Defined in terms of a(n) ronnagram.
    /// </summary>
    public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000,0);

}