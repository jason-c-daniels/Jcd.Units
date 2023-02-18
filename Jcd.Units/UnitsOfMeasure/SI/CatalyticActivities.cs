using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class CatalyticActivities : Enumeration<CatalyticActivities,CatalyticActivity>
{
    public static readonly CatalyticActivity Katal = new ("katal", "kat");
    public static readonly CatalyticActivity Decikatal = new ("decikatal", "dkat", Katal, 1.0/10.0,0);
    public static readonly CatalyticActivity Centikatal = new ("centikatal", "ckat", Decikatal, 1.0/10.0,0);
    public static readonly CatalyticActivity Millikatal = new ("millikatal", "mkat", Centikatal, 1.0/10.0,0);
    public static readonly CatalyticActivity Microkatal = new ("microkatal", "μkat", Millikatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Nanokatal = new ("nanokatal", "nkat", Microkatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Picokatal = new ("picokatal", "pkat", Nanokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Femtokatal = new ("femtokatal", "fkat", Picokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Attokatal = new ("attokatal", "akat", Femtokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Zeptokatal = new ("zeptokatal", "zkat", Attokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Yoctokatal = new ("yoctokatal", "ykat", Zeptokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Rontokatal = new ("rontokatal", "rkat", Yoctokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Quectokatal = new ("quectokatal", "qkat", Rontokatal, 1.0/1000.0,0);
    public static readonly CatalyticActivity Dekakatal = new ("dekakatal", "dakat", Katal, 10,0);
    public static readonly CatalyticActivity Hectokatal = new ("hectokatal", "hkat", Dekakatal, 10,0);
    public static readonly CatalyticActivity Kilokatal = new ("kilokatal", "kkat", Hectokatal, 10,0);
    public static readonly CatalyticActivity Megakatal = new ("megakatal", "Mkat", Kilokatal, 1000,0);
    public static readonly CatalyticActivity Gigakatal = new ("gigakatal", "Gkat", Megakatal, 1000,0);
    public static readonly CatalyticActivity Terakatal = new ("terakatal", "Tkat", Gigakatal, 1000,0);
    public static readonly CatalyticActivity Petakatal = new ("petakatal", "Pkat", Terakatal, 1000,0);
    public static readonly CatalyticActivity Exakatal = new ("exakatal", "Ekat", Petakatal, 1000,0);
    public static readonly CatalyticActivity Zettakatal = new ("zettakatal", "Zkat", Exakatal, 1000,0);
    public static readonly CatalyticActivity Yottakatal = new ("yottakatal", "Ykat", Zettakatal, 1000,0);
    public static readonly CatalyticActivity Ronnakatal = new ("ronnakatal", "Rkat", Yottakatal, 1000,0);
    public static readonly CatalyticActivity Quettakatal = new ("quettakatal", "Qkat", Ronnakatal, 1000,0);
}