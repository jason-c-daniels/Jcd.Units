using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Magnetic Flux.
/// </summary>
public class MagneticFluxes : Enumeration<MagneticFluxes,MagneticFlux>
{
    public static readonly MagneticFlux Weber = new ("weber", "Wb");
    public static readonly MagneticFlux Deciweber = new ("deciweber", "dWb", Weber, 1.0/10.0,0);
    public static readonly MagneticFlux Centiweber = new ("centiweber", "cWb", Deciweber, 1.0/10.0,0);
    public static readonly MagneticFlux Milliweber = new ("milliweber", "mWb", Centiweber, 1.0/10.0,0);
    public static readonly MagneticFlux Microweber = new ("microweber", "μWb", Milliweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Nanoweber = new ("nanoweber", "nWb", Microweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Picoweber = new ("picoweber", "pWb", Nanoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Femtoweber = new ("femtoweber", "fWb", Picoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Attoweber = new ("attoweber", "aWb", Femtoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Zeptoweber = new ("zeptoweber", "zWb", Attoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Yoctoweber = new ("yoctoweber", "yWb", Zeptoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Rontoweber = new ("rontoweber", "rWb", Yoctoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Quectoweber = new ("quectoweber", "qWb", Rontoweber, 1.0/1000.0,0);
    public static readonly MagneticFlux Dekaweber = new ("dekaweber", "daWb", Weber, 10,0);
    public static readonly MagneticFlux Hectoweber = new ("hectoweber", "hWb", Dekaweber, 10,0);
    public static readonly MagneticFlux Kiloweber = new ("kiloweber", "kWb", Hectoweber, 10,0);
    public static readonly MagneticFlux Megaweber = new ("megaweber", "MWb", Kiloweber, 1000,0);
    public static readonly MagneticFlux Gigaweber = new ("gigaweber", "GWb", Megaweber, 1000,0);
    public static readonly MagneticFlux Teraweber = new ("teraweber", "TWb", Gigaweber, 1000,0);
    public static readonly MagneticFlux Petaweber = new ("petaweber", "PWb", Teraweber, 1000,0);
    public static readonly MagneticFlux Exaweber = new ("exaweber", "EWb", Petaweber, 1000,0);
    public static readonly MagneticFlux Zettaweber = new ("zettaweber", "ZWb", Exaweber, 1000,0);
    public static readonly MagneticFlux Yottaweber = new ("yottaweber", "YWb", Zettaweber, 1000,0);
    public static readonly MagneticFlux Ronnaweber = new ("ronnaweber", "RWb", Yottaweber, 1000,0);
    public static readonly MagneticFlux Quettaweber = new ("quettaweber", "QWb", Ronnaweber, 1000,0);
}