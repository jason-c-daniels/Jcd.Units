using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Amount.
/// </summary>
public class Amounts : Enumeration<Amounts,Amount>
{
    /// <summary>
    /// Units of a mole. It's defined in terms of a(n)  count.
    /// </summary>
    public static readonly Amount Mole = new ("mole", "mol", UnitsOfMeasure.Amounts.Count, 6.02214076E+23,0);
    /// <summary>
    /// Units of a decimole. It's defined in terms of a(n)  mole.
    /// </summary>
    public static readonly Amount Decimole = new ("decimole", "dmol", Mole, 1.0/10.0,0);
    /// <summary>
    /// Units of a centimole. It's defined in terms of a(n)  decimole.
    /// </summary>
    public static readonly Amount Centimole = new ("centimole", "cmol", Decimole, 1.0/10.0,0);
    /// <summary>
    /// Units of a millimole. It's defined in terms of a(n)  centimole.
    /// </summary>
    public static readonly Amount Millimole = new ("millimole", "mmol", Centimole, 1.0/10.0,0);
    /// <summary>
    /// Units of a micromole. It's defined in terms of a(n)  millimole.
    /// </summary>
    public static readonly Amount Micromole = new ("micromole", "μmol", Millimole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanomole. It's defined in terms of a(n)  micromole.
    /// </summary>
    public static readonly Amount Nanomole = new ("nanomole", "nmol", Micromole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picomole. It's defined in terms of a(n)  nanomole.
    /// </summary>
    public static readonly Amount Picomole = new ("picomole", "pmol", Nanomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtomole. It's defined in terms of a(n)  picomole.
    /// </summary>
    public static readonly Amount Femtomole = new ("femtomole", "fmol", Picomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attomole. It's defined in terms of a(n)  femtomole.
    /// </summary>
    public static readonly Amount Attomole = new ("attomole", "amol", Femtomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptomole. It's defined in terms of a(n)  attomole.
    /// </summary>
    public static readonly Amount Zeptomole = new ("zeptomole", "zmol", Attomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctomole. It's defined in terms of a(n)  zeptomole.
    /// </summary>
    public static readonly Amount Yoctomole = new ("yoctomole", "ymol", Zeptomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontomole. It's defined in terms of a(n)  yoctomole.
    /// </summary>
    public static readonly Amount Rontomole = new ("rontomole", "rmol", Yoctomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectomole. It's defined in terms of a(n)  rontomole.
    /// </summary>
    public static readonly Amount Quectomole = new ("quectomole", "qmol", Rontomole, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekamole. It's defined in terms of a(n)  mole.
    /// </summary>
    public static readonly Amount Dekamole = new ("dekamole", "damol", Mole, 10,0);
    /// <summary>
    /// Units of a hectomole. It's defined in terms of a(n)  dekamole.
    /// </summary>
    public static readonly Amount Hectomole = new ("hectomole", "hmol", Dekamole, 10,0);
    /// <summary>
    /// Units of a kilomole. It's defined in terms of a(n)  hectomole.
    /// </summary>
    public static readonly Amount Kilomole = new ("kilomole", "kmol", Hectomole, 10,0);
    /// <summary>
    /// Units of a megamole. It's defined in terms of a(n)  kilomole.
    /// </summary>
    public static readonly Amount Megamole = new ("megamole", "Mmol", Kilomole, 1000,0);
    /// <summary>
    /// Units of a gigamole. It's defined in terms of a(n)  megamole.
    /// </summary>
    public static readonly Amount Gigamole = new ("gigamole", "Gmol", Megamole, 1000,0);
    /// <summary>
    /// Units of a teramole. It's defined in terms of a(n)  gigamole.
    /// </summary>
    public static readonly Amount Teramole = new ("teramole", "Tmol", Gigamole, 1000,0);
    /// <summary>
    /// Units of a petamole. It's defined in terms of a(n)  teramole.
    /// </summary>
    public static readonly Amount Petamole = new ("petamole", "Pmol", Teramole, 1000,0);
    /// <summary>
    /// Units of a examole. It's defined in terms of a(n)  petamole.
    /// </summary>
    public static readonly Amount Examole = new ("examole", "Emol", Petamole, 1000,0);
    /// <summary>
    /// Units of a zettamole. It's defined in terms of a(n)  examole.
    /// </summary>
    public static readonly Amount Zettamole = new ("zettamole", "Zmol", Examole, 1000,0);
    /// <summary>
    /// Units of a yottamole. It's defined in terms of a(n)  zettamole.
    /// </summary>
    public static readonly Amount Yottamole = new ("yottamole", "Ymol", Zettamole, 1000,0);
    /// <summary>
    /// Units of a ronnamole. It's defined in terms of a(n)  yottamole.
    /// </summary>
    public static readonly Amount Ronnamole = new ("ronnamole", "Rmol", Yottamole, 1000,0);
    /// <summary>
    /// Units of a quettamole. It's defined in terms of a(n)  ronnamole.
    /// </summary>
    public static readonly Amount Quettamole = new ("quettamole", "Qmol", Ronnamole, 1000,0);

}