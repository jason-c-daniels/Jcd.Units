using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Magnetic Flux.
/// </summary>
public class MagneticFluxes : Enumeration<MagneticFluxes,MagneticFlux>
{


    /// <summary>
    /// A(n) weber.
    /// </summary>
    public static readonly MagneticFlux Weber = new ("weber", "Wb");
    /// <summary>
    /// A(n) deciweber. It's defined in terms of a(n) weber.
    /// </summary>
    public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) centiweber. It's defined in terms of a(n) deciweber.
    /// </summary>
    public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) milliweber. It's defined in terms of a(n) centiweber.
    /// </summary>
    public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0/10.0,0);
    
    /// <summary>
    /// A(n) microweber. It's defined in terms of a(n) milliweber.
    /// </summary>
    public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) nanoweber. It's defined in terms of a(n) microweber.
    /// </summary>
    public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) picoweber. It's defined in terms of a(n) nanoweber.
    /// </summary>
    public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) femtoweber. It's defined in terms of a(n) picoweber.
    /// </summary>
    public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) attoweber. It's defined in terms of a(n) femtoweber.
    /// </summary>
    public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) zeptoweber. It's defined in terms of a(n) attoweber.
    /// </summary>
    public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) yoctoweber. It's defined in terms of a(n) zeptoweber.
    /// </summary>
    public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) rontoweber. It's defined in terms of a(n) yoctoweber.
    /// </summary>
    public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) quectoweber. It's defined in terms of a(n) rontoweber.
    /// </summary>
    public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0/1000.0,0);
    
    /// <summary>
    /// A(n) dekaweber. It's defined in terms of a(n) weber.
    /// </summary>
    public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10,0);
    
    /// <summary>
    /// A(n) hectoweber. It's defined in terms of a(n) dekaweber.
    /// </summary>
    public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10,0);
    
    /// <summary>
    /// A(n) kiloweber. It's defined in terms of a(n) hectoweber.
    /// </summary>
    public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10,0);
    
    /// <summary>
    /// A(n) megaweber. It's defined in terms of a(n) kiloweber.
    /// </summary>
    public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000,0);
    
    /// <summary>
    /// A(n) gigaweber. It's defined in terms of a(n) megaweber.
    /// </summary>
    public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000,0);
    
    /// <summary>
    /// A(n) teraweber. It's defined in terms of a(n) gigaweber.
    /// </summary>
    public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000,0);
    
    /// <summary>
    /// A(n) petaweber. It's defined in terms of a(n) teraweber.
    /// </summary>
    public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000,0);
    
    /// <summary>
    /// A(n) exaweber. It's defined in terms of a(n) petaweber.
    /// </summary>
    public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000,0);
    
    /// <summary>
    /// A(n) zettaweber. It's defined in terms of a(n) exaweber.
    /// </summary>
    public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000,0);
    
    /// <summary>
    /// A(n) yottaweber. It's defined in terms of a(n) zettaweber.
    /// </summary>
    public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000,0);
    
    /// <summary>
    /// A(n) ronnaweber. It's defined in terms of a(n) yottaweber.
    /// </summary>
    public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000,0);
    
    /// <summary>
    /// A(n) quettaweber. It's defined in terms of a(n) ronnaweber.
    /// </summary>
    public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000,0);

}