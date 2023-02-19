using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Mass.
/// </summary>
public class Masses : Enumeration<Masses,Mass>
{

    /// <summary>
    /// Units of a gram.
    /// </summary>
    public static readonly Mass Gram = new ("gram", "g");
    /// <summary>
    /// Units of a decigram. It's defined in terms of a(n) SI gram.
    /// </summary>
    public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0/10.0,0);
    /// <summary>
    /// Units of a centigram. It's defined in terms of a(n) SI decigram.
    /// </summary>
    public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0/10.0,0);
    /// <summary>
    /// Units of a milligram. It's defined in terms of a(n) SI centigram.
    /// </summary>
    public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0/10.0,0);
    /// <summary>
    /// Units of a microgram. It's defined in terms of a(n) SI milligram.
    /// </summary>
    public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanogram. It's defined in terms of a(n) SI microgram.
    /// </summary>
    public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picogram. It's defined in terms of a(n) SI nanogram.
    /// </summary>
    public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtogram. It's defined in terms of a(n) SI picogram.
    /// </summary>
    public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attogram. It's defined in terms of a(n) SI femtogram.
    /// </summary>
    public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptogram. It's defined in terms of a(n) SI attogram.
    /// </summary>
    public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctogram. It's defined in terms of a(n) SI zeptogram.
    /// </summary>
    public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontogram. It's defined in terms of a(n) SI yoctogram.
    /// </summary>
    public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectogram. It's defined in terms of a(n) SI rontogram.
    /// </summary>
    public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekagram. It's defined in terms of a(n) SI gram.
    /// </summary>
    public static readonly Mass Dekagram = new ("dekagram", "dag", Gram, 10,0);
    /// <summary>
    /// Units of a hectogram. It's defined in terms of a(n) SI dekagram.
    /// </summary>
    public static readonly Mass Hectogram = new ("hectogram", "hg", Dekagram, 10,0);
    /// <summary>
    /// Units of a kilogram. It's defined in terms of a(n) SI hectogram.
    /// </summary>
    public static readonly Mass Kilogram = new ("kilogram", "kg", Hectogram, 10,0);
    /// <summary>
    /// Units of a megagram. It's defined in terms of a(n) SI kilogram.
    /// </summary>
    public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000,0);
    /// <summary>
    /// Units of a gigagram. It's defined in terms of a(n) SI megagram.
    /// </summary>
    public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000,0);
    /// <summary>
    /// Units of a teragram. It's defined in terms of a(n) SI gigagram.
    /// </summary>
    public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000,0);
    /// <summary>
    /// Units of a petagram. It's defined in terms of a(n) SI teragram.
    /// </summary>
    public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000,0);
    /// <summary>
    /// Units of a exagram. It's defined in terms of a(n) SI petagram.
    /// </summary>
    public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000,0);
    /// <summary>
    /// Units of a zettagram. It's defined in terms of a(n) SI exagram.
    /// </summary>
    public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000,0);
    /// <summary>
    /// Units of a yottagram. It's defined in terms of a(n) SI zettagram.
    /// </summary>
    public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000,0);
    /// <summary>
    /// Units of a ronnagram. It's defined in terms of a(n) SI yottagram.
    /// </summary>
    public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000,0);
    /// <summary>
    /// Units of a quettagram. It's defined in terms of a(n) SI ronnagram.
    /// </summary>
    public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000,0);

}