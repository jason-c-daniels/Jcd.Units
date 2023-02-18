using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure.SI;

public class Momentums : Enumeration<Momentums,Momentum>
{
    public static readonly Momentum NewtonSecond = new ("newton-second", "N⋅s");
    public static readonly Momentum DecinewtonSecond = new ("decinewton-second", "dN⋅s", NewtonSecond, 1.0/10.0,0);
    public static readonly Momentum CentinewtonSecond = new ("centinewton-second", "cN⋅s", DecinewtonSecond, 1.0/10.0,0);
    public static readonly Momentum MillinewtonSecond = new ("millinewton-second", "mN⋅s", CentinewtonSecond, 1.0/10.0,0);
    public static readonly Momentum MicronewtonSecond = new ("micronewton-second", "μN⋅s", MillinewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum NanonewtonSecond = new ("nanonewton-second", "nN⋅s", MicronewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum PiconewtonSecond = new ("piconewton-second", "pN⋅s", NanonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum FemtonewtonSecond = new ("femtonewton-second", "fN⋅s", PiconewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum AttonewtonSecond = new ("attonewton-second", "aN⋅s", FemtonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum ZeptonewtonSecond = new ("zeptonewton-second", "zN⋅s", AttonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum YoctonewtonSecond = new ("yoctonewton-second", "yN⋅s", ZeptonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum RontonewtonSecond = new ("rontonewton-second", "rN⋅s", YoctonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum QuectonewtonSecond = new ("quectonewton-second", "qN⋅s", RontonewtonSecond, 1.0/1000.0,0);
    public static readonly Momentum DekanewtonSecond = new ("dekanewton-second", "daN⋅s", NewtonSecond, 10,0);
    public static readonly Momentum HectonewtonSecond = new ("hectonewton-second", "hN⋅s", DekanewtonSecond, 10,0);
    public static readonly Momentum KilonewtonSecond = new ("kilonewton-second", "kN⋅s", HectonewtonSecond, 10,0);
    public static readonly Momentum MeganewtonSecond = new ("meganewton-second", "MN⋅s", KilonewtonSecond, 1000,0);
    public static readonly Momentum GiganewtonSecond = new ("giganewton-second", "GN⋅s", MeganewtonSecond, 1000,0);
    public static readonly Momentum TeranewtonSecond = new ("teranewton-second", "TN⋅s", GiganewtonSecond, 1000,0);
    public static readonly Momentum PetanewtonSecond = new ("petanewton-second", "PN⋅s", TeranewtonSecond, 1000,0);
    public static readonly Momentum ExanewtonSecond = new ("exanewton-second", "EN⋅s", PetanewtonSecond, 1000,0);
    public static readonly Momentum ZettanewtonSecond = new ("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000,0);
    public static readonly Momentum YottanewtonSecond = new ("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000,0);
    public static readonly Momentum RonnanewtonSecond = new ("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000,0);
    public static readonly Momentum QuettanewtonSecond = new ("quettanewton-second", "QN⋅s", RonnanewtonSecond, 1000,0);
}