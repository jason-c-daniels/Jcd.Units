#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Momentum.
/// </summary>
public class Momentums : UnitOfMeasureEnumeration<Momentums, Momentum>
{
   /// <summary>
   /// newton-second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this
   /// type.)
   /// </summary>
   public static readonly Momentum NewtonSecond = new("newton-second", "N⋅s", system: "SI");

   /// <summary>
   /// decinewton-second defined such that: newton-second = dN⋅s × 1.0/10.0.
   /// </summary>
   public static readonly Momentum DecinewtonSecond = new("decinewton-second", "dN⋅s", NewtonSecond, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centinewton-second defined such that: decinewton-second = cN⋅s × 1.0/10.0.
   /// </summary>
   public static readonly Momentum CentinewtonSecond = new("centinewton-second", "cN⋅s", DecinewtonSecond, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millinewton-second defined such that: centinewton-second = mN⋅s × 1.0/10.0.
   /// </summary>
   public static readonly Momentum MillinewtonSecond = new("millinewton-second", "mN⋅s", CentinewtonSecond, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// micronewton-second defined such that: millinewton-second = μN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum MicronewtonSecond = new("micronewton-second", "μN⋅s", MillinewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanonewton-second defined such that: micronewton-second = nN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum NanonewtonSecond = new("nanonewton-second", "nN⋅s", MicronewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// piconewton-second defined such that: nanonewton-second = pN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum PiconewtonSecond = new("piconewton-second", "pN⋅s", NanonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtonewton-second defined such that: piconewton-second = fN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum FemtonewtonSecond = new("femtonewton-second", "fN⋅s", PiconewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attonewton-second defined such that: femtonewton-second = aN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum AttonewtonSecond = new("attonewton-second", "aN⋅s", FemtonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptonewton-second defined such that: attonewton-second = zN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum ZeptonewtonSecond = new("zeptonewton-second", "zN⋅s", AttonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctonewton-second defined such that: zeptonewton-second = yN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum YoctonewtonSecond = new("yoctonewton-second", "yN⋅s", ZeptonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontonewton-second defined such that: yoctonewton-second = rN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum RontonewtonSecond = new("rontonewton-second", "rN⋅s", YoctonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectonewton-second defined such that: rontonewton-second = qN⋅s × 1.0/1000.0.
   /// </summary>
   public static readonly Momentum QuectonewtonSecond = new("quectonewton-second", "qN⋅s", RontonewtonSecond, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekanewton-second defined such that: newton-second = daN⋅s × 10.0.
   /// </summary>
   public static readonly Momentum DekanewtonSecond = new("dekanewton-second", "daN⋅s", NewtonSecond, 10.0, system: "SI");

   /// <summary>
   /// hectonewton-second defined such that: dekanewton-second = hN⋅s × 10.0.
   /// </summary>
   public static readonly Momentum HectonewtonSecond = new("hectonewton-second", "hN⋅s", DekanewtonSecond, 10.0, system: "SI");

   /// <summary>
   /// kilonewton-second defined such that: hectonewton-second = kN⋅s × 10.0.
   /// </summary>
   public static readonly Momentum KilonewtonSecond = new("kilonewton-second", "kN⋅s", HectonewtonSecond, 10.0, system: "SI");

   /// <summary>
   /// meganewton-second defined such that: kilonewton-second = MN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum MeganewtonSecond = new("meganewton-second", "MN⋅s", KilonewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// giganewton-second defined such that: meganewton-second = GN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum GiganewtonSecond = new("giganewton-second", "GN⋅s", MeganewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// teranewton-second defined such that: giganewton-second = TN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum TeranewtonSecond = new("teranewton-second", "TN⋅s", GiganewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// petanewton-second defined such that: teranewton-second = PN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum PetanewtonSecond = new("petanewton-second", "PN⋅s", TeranewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// exanewton-second defined such that: petanewton-second = EN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum ExanewtonSecond = new("exanewton-second", "EN⋅s", PetanewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// zettanewton-second defined such that: exanewton-second = ZN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum ZettanewtonSecond = new("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// yottanewton-second defined such that: zettanewton-second = YN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum YottanewtonSecond = new("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// ronnanewton-second defined such that: yottanewton-second = RN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum RonnanewtonSecond = new("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000.0, system: "SI");

   /// <summary>
   /// quettanewton-second defined such that: ronnanewton-second = QN⋅s × 1000.0.
   /// </summary>
   public static readonly Momentum QuettanewtonSecond = new("quettanewton-second", "QN⋅s", RonnanewtonSecond, 1000.0, system: "SI");
}