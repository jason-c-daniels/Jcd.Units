using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Amount.
/// </summary>
public class Amounts : Enumeration<Amounts,Amount>
{
    public static readonly Amount Mole = new ("mole", "mol", UnitsOfMeasure.Amounts.Count, 6.02214076E+23,0);
    public static readonly Amount Decimole = new ("decimole", "dmol", Mole, 1.0/10.0,0);
    public static readonly Amount Centimole = new ("centimole", "cmol", Decimole, 1.0/10.0,0);
    public static readonly Amount Millimole = new ("millimole", "mmol", Centimole, 1.0/10.0,0);
    public static readonly Amount Micromole = new ("micromole", "μmol", Millimole, 1.0/1000.0,0);
    public static readonly Amount Nanomole = new ("nanomole", "nmol", Micromole, 1.0/1000.0,0);
    public static readonly Amount Picomole = new ("picomole", "pmol", Nanomole, 1.0/1000.0,0);
    public static readonly Amount Femtomole = new ("femtomole", "fmol", Picomole, 1.0/1000.0,0);
    public static readonly Amount Attomole = new ("attomole", "amol", Femtomole, 1.0/1000.0,0);
    public static readonly Amount Zeptomole = new ("zeptomole", "zmol", Attomole, 1.0/1000.0,0);
    public static readonly Amount Yoctomole = new ("yoctomole", "ymol", Zeptomole, 1.0/1000.0,0);
    public static readonly Amount Rontomole = new ("rontomole", "rmol", Yoctomole, 1.0/1000.0,0);
    public static readonly Amount Quectomole = new ("quectomole", "qmol", Rontomole, 1.0/1000.0,0);
    public static readonly Amount Dekamole = new ("dekamole", "damol", Mole, 10,0);
    public static readonly Amount Hectomole = new ("hectomole", "hmol", Dekamole, 10,0);
    public static readonly Amount Kilomole = new ("kilomole", "kmol", Hectomole, 10,0);
    public static readonly Amount Megamole = new ("megamole", "Mmol", Kilomole, 1000,0);
    public static readonly Amount Gigamole = new ("gigamole", "Gmol", Megamole, 1000,0);
    public static readonly Amount Teramole = new ("teramole", "Tmol", Gigamole, 1000,0);
    public static readonly Amount Petamole = new ("petamole", "Pmol", Teramole, 1000,0);
    public static readonly Amount Examole = new ("examole", "Emol", Petamole, 1000,0);
    public static readonly Amount Zettamole = new ("zettamole", "Zmol", Examole, 1000,0);
    public static readonly Amount Yottamole = new ("yottamole", "Ymol", Zettamole, 1000,0);
    public static readonly Amount Ronnamole = new ("ronnamole", "Rmol", Yottamole, 1000,0);
    public static readonly Amount Quettamole = new ("quettamole", "Qmol", Ronnamole, 1000,0);
}