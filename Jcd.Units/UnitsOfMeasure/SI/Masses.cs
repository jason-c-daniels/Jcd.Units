using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Mass.
/// </summary>
public class Masses : Enumeration<Masses,Mass>
{
    public static readonly Mass Gram = new ("gram", "g");
    public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0/10.0,0);
    public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0/10.0,0);
    public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0/10.0,0);
    public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0/1000.0,0);
    public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0/1000.0,0);
    public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0/1000.0,0);
    public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0/1000.0,0);
    public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0/1000.0,0);
    public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0/1000.0,0);
    public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0/1000.0,0);
    public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0/1000.0,0);
    public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0/1000.0,0);
    public static readonly Mass Dekagram = new ("dekagram", "dag", Gram, 10,0);
    public static readonly Mass Hectogram = new ("hectogram", "hg", Dekagram, 10,0);
    public static readonly Mass Kilogram = new ("kilogram", "kg", Hectogram, 10,0);
    public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000,0);
    public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000,0);
    public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000,0);
    public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000,0);
    public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000,0);
    public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000,0);
    public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000,0);
    public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000,0);
    public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000,0);
}