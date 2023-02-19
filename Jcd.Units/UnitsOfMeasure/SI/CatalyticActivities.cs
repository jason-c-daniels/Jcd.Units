using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Catalytic Activity.
/// </summary>
public class CatalyticActivities : Enumeration<CatalyticActivities,CatalyticActivity>
{

    /// <summary>
    /// Units of a katal.
    /// </summary>
    public static readonly CatalyticActivity Katal = new ("katal", "kat");
    /// <summary>
    /// Units of a decikatal. It's defined in terms of a(n) SI katal.
    /// </summary>
    public static readonly CatalyticActivity Decikatal = new ("decikatal", "dkat", Katal, 1.0/10.0,0);
    /// <summary>
    /// Units of a centikatal. It's defined in terms of a(n) SI decikatal.
    /// </summary>
    public static readonly CatalyticActivity Centikatal = new ("centikatal", "ckat", Decikatal, 1.0/10.0,0);
    /// <summary>
    /// Units of a millikatal. It's defined in terms of a(n) SI centikatal.
    /// </summary>
    public static readonly CatalyticActivity Millikatal = new ("millikatal", "mkat", Centikatal, 1.0/10.0,0);
    /// <summary>
    /// Units of a microkatal. It's defined in terms of a(n) SI millikatal.
    /// </summary>
    public static readonly CatalyticActivity Microkatal = new ("microkatal", "μkat", Millikatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanokatal. It's defined in terms of a(n) SI microkatal.
    /// </summary>
    public static readonly CatalyticActivity Nanokatal = new ("nanokatal", "nkat", Microkatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picokatal. It's defined in terms of a(n) SI nanokatal.
    /// </summary>
    public static readonly CatalyticActivity Picokatal = new ("picokatal", "pkat", Nanokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtokatal. It's defined in terms of a(n) SI picokatal.
    /// </summary>
    public static readonly CatalyticActivity Femtokatal = new ("femtokatal", "fkat", Picokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attokatal. It's defined in terms of a(n) SI femtokatal.
    /// </summary>
    public static readonly CatalyticActivity Attokatal = new ("attokatal", "akat", Femtokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptokatal. It's defined in terms of a(n) SI attokatal.
    /// </summary>
    public static readonly CatalyticActivity Zeptokatal = new ("zeptokatal", "zkat", Attokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctokatal. It's defined in terms of a(n) SI zeptokatal.
    /// </summary>
    public static readonly CatalyticActivity Yoctokatal = new ("yoctokatal", "ykat", Zeptokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontokatal. It's defined in terms of a(n) SI yoctokatal.
    /// </summary>
    public static readonly CatalyticActivity Rontokatal = new ("rontokatal", "rkat", Yoctokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectokatal. It's defined in terms of a(n) SI rontokatal.
    /// </summary>
    public static readonly CatalyticActivity Quectokatal = new ("quectokatal", "qkat", Rontokatal, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekakatal. It's defined in terms of a(n) SI katal.
    /// </summary>
    public static readonly CatalyticActivity Dekakatal = new ("dekakatal", "dakat", Katal, 10,0);
    /// <summary>
    /// Units of a hectokatal. It's defined in terms of a(n) SI dekakatal.
    /// </summary>
    public static readonly CatalyticActivity Hectokatal = new ("hectokatal", "hkat", Dekakatal, 10,0);
    /// <summary>
    /// Units of a kilokatal. It's defined in terms of a(n) SI hectokatal.
    /// </summary>
    public static readonly CatalyticActivity Kilokatal = new ("kilokatal", "kkat", Hectokatal, 10,0);
    /// <summary>
    /// Units of a megakatal. It's defined in terms of a(n) SI kilokatal.
    /// </summary>
    public static readonly CatalyticActivity Megakatal = new ("megakatal", "Mkat", Kilokatal, 1000,0);
    /// <summary>
    /// Units of a gigakatal. It's defined in terms of a(n) SI megakatal.
    /// </summary>
    public static readonly CatalyticActivity Gigakatal = new ("gigakatal", "Gkat", Megakatal, 1000,0);
    /// <summary>
    /// Units of a terakatal. It's defined in terms of a(n) SI gigakatal.
    /// </summary>
    public static readonly CatalyticActivity Terakatal = new ("terakatal", "Tkat", Gigakatal, 1000,0);
    /// <summary>
    /// Units of a petakatal. It's defined in terms of a(n) SI terakatal.
    /// </summary>
    public static readonly CatalyticActivity Petakatal = new ("petakatal", "Pkat", Terakatal, 1000,0);
    /// <summary>
    /// Units of a exakatal. It's defined in terms of a(n) SI petakatal.
    /// </summary>
    public static readonly CatalyticActivity Exakatal = new ("exakatal", "Ekat", Petakatal, 1000,0);
    /// <summary>
    /// Units of a zettakatal. It's defined in terms of a(n) SI exakatal.
    /// </summary>
    public static readonly CatalyticActivity Zettakatal = new ("zettakatal", "Zkat", Exakatal, 1000,0);
    /// <summary>
    /// Units of a yottakatal. It's defined in terms of a(n) SI zettakatal.
    /// </summary>
    public static readonly CatalyticActivity Yottakatal = new ("yottakatal", "Ykat", Zettakatal, 1000,0);
    /// <summary>
    /// Units of a ronnakatal. It's defined in terms of a(n) SI yottakatal.
    /// </summary>
    public static readonly CatalyticActivity Ronnakatal = new ("ronnakatal", "Rkat", Yottakatal, 1000,0);
    /// <summary>
    /// Units of a quettakatal. It's defined in terms of a(n) SI ronnakatal.
    /// </summary>
    public static readonly CatalyticActivity Quettakatal = new ("quettakatal", "Qkat", Ronnakatal, 1000,0);

}