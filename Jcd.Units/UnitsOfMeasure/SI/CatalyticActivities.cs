using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Catalytic Activity.
/// </summary>
public class CatalyticActivities : Enumeration<CatalyticActivities,CatalyticActivity>
{


    /// <summary>
    /// A(n) katal.
    /// </summary>
    public static readonly CatalyticActivity Katal = new ("katal", "kat");
    /// <summary>
    /// A(n) decikatal. It's defined in terms of a(n) katal.
    /// </summary>
    public static readonly CatalyticActivity Decikatal = new ("decikatal", "dkat", Katal, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centikatal. It's defined in terms of a(n) decikatal.
    /// </summary>
    public static readonly CatalyticActivity Centikatal = new ("centikatal", "ckat", Decikatal, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) millikatal. It's defined in terms of a(n) centikatal.
    /// </summary>
    public static readonly CatalyticActivity Millikatal = new ("millikatal", "mkat", Centikatal, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microkatal. It's defined in terms of a(n) millikatal.
    /// </summary>
    public static readonly CatalyticActivity Microkatal = new ("microkatal", "μkat", Millikatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanokatal. It's defined in terms of a(n) microkatal.
    /// </summary>
    public static readonly CatalyticActivity Nanokatal = new ("nanokatal", "nkat", Microkatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picokatal. It's defined in terms of a(n) nanokatal.
    /// </summary>
    public static readonly CatalyticActivity Picokatal = new ("picokatal", "pkat", Nanokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtokatal. It's defined in terms of a(n) picokatal.
    /// </summary>
    public static readonly CatalyticActivity Femtokatal = new ("femtokatal", "fkat", Picokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attokatal. It's defined in terms of a(n) femtokatal.
    /// </summary>
    public static readonly CatalyticActivity Attokatal = new ("attokatal", "akat", Femtokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptokatal. It's defined in terms of a(n) attokatal.
    /// </summary>
    public static readonly CatalyticActivity Zeptokatal = new ("zeptokatal", "zkat", Attokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctokatal. It's defined in terms of a(n) zeptokatal.
    /// </summary>
    public static readonly CatalyticActivity Yoctokatal = new ("yoctokatal", "ykat", Zeptokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontokatal. It's defined in terms of a(n) yoctokatal.
    /// </summary>
    public static readonly CatalyticActivity Rontokatal = new ("rontokatal", "rkat", Yoctokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectokatal. It's defined in terms of a(n) rontokatal.
    /// </summary>
    public static readonly CatalyticActivity Quectokatal = new ("quectokatal", "qkat", Rontokatal, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekakatal. It's defined in terms of a(n) katal.
    /// </summary>
    public static readonly CatalyticActivity Dekakatal = new ("dekakatal", "dakat", Katal, 10,0);
    
    /// <summary>
    /// A(n) hectokatal. It's defined in terms of a(n) dekakatal.
    /// </summary>
    public static readonly CatalyticActivity Hectokatal = new ("hectokatal", "hkat", Dekakatal, 10,0);
    
    /// <summary>
    /// A(n) kilokatal. It's defined in terms of a(n) hectokatal.
    /// </summary>
    public static readonly CatalyticActivity Kilokatal = new ("kilokatal", "kkat", Hectokatal, 10,0);
    
    /// <summary>
    /// A(n) megakatal. It's defined in terms of a(n) kilokatal.
    /// </summary>
    public static readonly CatalyticActivity Megakatal = new ("megakatal", "Mkat", Kilokatal, 1000,0);
    
    /// <summary>
    /// A(n) gigakatal. It's defined in terms of a(n) megakatal.
    /// </summary>
    public static readonly CatalyticActivity Gigakatal = new ("gigakatal", "Gkat", Megakatal, 1000,0);
    
    /// <summary>
    /// A(n) terakatal. It's defined in terms of a(n) gigakatal.
    /// </summary>
    public static readonly CatalyticActivity Terakatal = new ("terakatal", "Tkat", Gigakatal, 1000,0);
    
    /// <summary>
    /// A(n) petakatal. It's defined in terms of a(n) terakatal.
    /// </summary>
    public static readonly CatalyticActivity Petakatal = new ("petakatal", "Pkat", Terakatal, 1000,0);
    
    /// <summary>
    /// A(n) exakatal. It's defined in terms of a(n) petakatal.
    /// </summary>
    public static readonly CatalyticActivity Exakatal = new ("exakatal", "Ekat", Petakatal, 1000,0);
    
    /// <summary>
    /// A(n) zettakatal. It's defined in terms of a(n) exakatal.
    /// </summary>
    public static readonly CatalyticActivity Zettakatal = new ("zettakatal", "Zkat", Exakatal, 1000,0);
    
    /// <summary>
    /// A(n) yottakatal. It's defined in terms of a(n) zettakatal.
    /// </summary>
    public static readonly CatalyticActivity Yottakatal = new ("yottakatal", "Ykat", Zettakatal, 1000,0);
    
    /// <summary>
    /// A(n) ronnakatal. It's defined in terms of a(n) yottakatal.
    /// </summary>
    public static readonly CatalyticActivity Ronnakatal = new ("ronnakatal", "Rkat", Yottakatal, 1000,0);
    
    /// <summary>
    /// A(n) quettakatal. It's defined in terms of a(n) ronnakatal.
    /// </summary>
    public static readonly CatalyticActivity Quettakatal = new ("quettakatal", "Qkat", Ronnakatal, 1000,0);

}