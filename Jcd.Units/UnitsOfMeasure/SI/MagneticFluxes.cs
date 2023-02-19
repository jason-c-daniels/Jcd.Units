using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Magnetic Flux.
/// </summary>
public class MagneticFluxes : Enumeration<MagneticFluxes,MagneticFlux>
{

    /// <summary>
    /// Units of a weber.
    /// </summary>
    public static readonly MagneticFlux Weber = new ("weber", "Wb");
    /// <summary>
    /// Units of a deciweber. It's defined in terms of a(n) SI weber.
    /// </summary>
    public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0/10.0,0);
    /// <summary>
    /// Units of a centiweber. It's defined in terms of a(n) SI deciweber.
    /// </summary>
    public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0/10.0,0);
    /// <summary>
    /// Units of a milliweber. It's defined in terms of a(n) SI centiweber.
    /// </summary>
    public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0/10.0,0);
    /// <summary>
    /// Units of a microweber. It's defined in terms of a(n) SI milliweber.
    /// </summary>
    public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a nanoweber. It's defined in terms of a(n) SI microweber.
    /// </summary>
    public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a picoweber. It's defined in terms of a(n) SI nanoweber.
    /// </summary>
    public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a femtoweber. It's defined in terms of a(n) SI picoweber.
    /// </summary>
    public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a attoweber. It's defined in terms of a(n) SI femtoweber.
    /// </summary>
    public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a zeptoweber. It's defined in terms of a(n) SI attoweber.
    /// </summary>
    public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a yoctoweber. It's defined in terms of a(n) SI zeptoweber.
    /// </summary>
    public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a rontoweber. It's defined in terms of a(n) SI yoctoweber.
    /// </summary>
    public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a quectoweber. It's defined in terms of a(n) SI rontoweber.
    /// </summary>
    public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0/1000.0,0);
    /// <summary>
    /// Units of a dekaweber. It's defined in terms of a(n) SI weber.
    /// </summary>
    public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10,0);
    /// <summary>
    /// Units of a hectoweber. It's defined in terms of a(n) SI dekaweber.
    /// </summary>
    public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10,0);
    /// <summary>
    /// Units of a kiloweber. It's defined in terms of a(n) SI hectoweber.
    /// </summary>
    public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10,0);
    /// <summary>
    /// Units of a megaweber. It's defined in terms of a(n) SI kiloweber.
    /// </summary>
    public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000,0);
    /// <summary>
    /// Units of a gigaweber. It's defined in terms of a(n) SI megaweber.
    /// </summary>
    public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000,0);
    /// <summary>
    /// Units of a teraweber. It's defined in terms of a(n) SI gigaweber.
    /// </summary>
    public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000,0);
    /// <summary>
    /// Units of a petaweber. It's defined in terms of a(n) SI teraweber.
    /// </summary>
    public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000,0);
    /// <summary>
    /// Units of a exaweber. It's defined in terms of a(n) SI petaweber.
    /// </summary>
    public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000,0);
    /// <summary>
    /// Units of a zettaweber. It's defined in terms of a(n) SI exaweber.
    /// </summary>
    public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000,0);
    /// <summary>
    /// Units of a yottaweber. It's defined in terms of a(n) SI zettaweber.
    /// </summary>
    public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000,0);
    /// <summary>
    /// Units of a ronnaweber. It's defined in terms of a(n) SI yottaweber.
    /// </summary>
    public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000,0);
    /// <summary>
    /// Units of a quettaweber. It's defined in terms of a(n) SI ronnaweber.
    /// </summary>
    public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000,0);

}