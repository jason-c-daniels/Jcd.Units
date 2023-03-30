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
   /// newton-second, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Momentum NewtonSecond = new ("newton-second", "N⋅s");

   /// <summary>
   /// decinewton-second, defined as: newton-second × 1.0/10.0
   /// </summary>
   public static readonly Momentum DecinewtonSecond = new ("decinewton-second", "dN⋅s", NewtonSecond, 1.0 / 10.0);

   /// <summary>
   /// centinewton-second, defined as: decinewton-second × 1.0/10.0
   /// </summary>
   public static readonly Momentum CentinewtonSecond = new ("centinewton-second", "cN⋅s", DecinewtonSecond, 1.0 / 10.0);

   /// <summary>
   /// millinewton-second, defined as: centinewton-second × 1.0/10.0
   /// </summary>
   public static readonly Momentum MillinewtonSecond = new (
                                                            "millinewton-second"
                                                          , "mN⋅s"
                                                          , CentinewtonSecond
                                                          , 1.0 / 10.0
                                                           );

   /// <summary>
   /// micronewton-second, defined as: millinewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum MicronewtonSecond = new (
                                                            "micronewton-second"
                                                          , "μN⋅s"
                                                          , MillinewtonSecond
                                                          , 1.0 / 1000.0
                                                           );

   /// <summary>
   /// nanonewton-second, defined as: micronewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum NanonewtonSecond = new (
                                                           "nanonewton-second"
                                                         , "nN⋅s"
                                                         , MicronewtonSecond
                                                         , 1.0 / 1000.0
                                                          );

   /// <summary>
   /// piconewton-second, defined as: nanonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum PiconewtonSecond = new ("piconewton-second", "pN⋅s", NanonewtonSecond, 1.0 / 1000.0);

   /// <summary>
   /// femtonewton-second, defined as: piconewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum FemtonewtonSecond = new (
                                                            "femtonewton-second"
                                                          , "fN⋅s"
                                                          , PiconewtonSecond
                                                          , 1.0 / 1000.0
                                                           );

   /// <summary>
   /// attonewton-second, defined as: femtonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum AttonewtonSecond = new (
                                                           "attonewton-second"
                                                         , "aN⋅s"
                                                         , FemtonewtonSecond
                                                         , 1.0 / 1000.0
                                                          );

   /// <summary>
   /// zeptonewton-second, defined as: attonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum ZeptonewtonSecond = new (
                                                            "zeptonewton-second"
                                                          , "zN⋅s"
                                                          , AttonewtonSecond
                                                          , 1.0 / 1000.0
                                                           );

   /// <summary>
   /// yoctonewton-second, defined as: zeptonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum YoctonewtonSecond = new (
                                                            "yoctonewton-second"
                                                          , "yN⋅s"
                                                          , ZeptonewtonSecond
                                                          , 1.0 / 1000.0
                                                           );

   /// <summary>
   /// rontonewton-second, defined as: yoctonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum RontonewtonSecond = new (
                                                            "rontonewton-second"
                                                          , "rN⋅s"
                                                          , YoctonewtonSecond
                                                          , 1.0 / 1000.0
                                                           );

   /// <summary>
   /// quectonewton-second, defined as: rontonewton-second × 1.0/1000.0
   /// </summary>
   public static readonly Momentum QuectonewtonSecond = new (
                                                             "quectonewton-second"
                                                           , "qN⋅s"
                                                           , RontonewtonSecond
                                                           , 1.0 / 1000.0
                                                            );

   /// <summary>
   /// dekanewton-second, defined as: newton-second × 10.0
   /// </summary>
   public static readonly Momentum DekanewtonSecond = new ("dekanewton-second", "daN⋅s", NewtonSecond, 10.0);

   /// <summary>
   /// hectonewton-second, defined as: dekanewton-second × 10.0
   /// </summary>
   public static readonly Momentum HectonewtonSecond = new ("hectonewton-second", "hN⋅s", DekanewtonSecond, 10.0);

   /// <summary>
   /// kilonewton-second, defined as: hectonewton-second × 10.0
   /// </summary>
   public static readonly Momentum KilonewtonSecond = new ("kilonewton-second", "kN⋅s", HectonewtonSecond, 10.0);

   /// <summary>
   /// meganewton-second, defined as: kilonewton-second × 1000.0
   /// </summary>
   public static readonly Momentum MeganewtonSecond = new ("meganewton-second", "MN⋅s", KilonewtonSecond, 1000.0);

   /// <summary>
   /// giganewton-second, defined as: meganewton-second × 1000.0
   /// </summary>
   public static readonly Momentum GiganewtonSecond = new ("giganewton-second", "GN⋅s", MeganewtonSecond, 1000.0);

   /// <summary>
   /// teranewton-second, defined as: giganewton-second × 1000.0
   /// </summary>
   public static readonly Momentum TeranewtonSecond = new ("teranewton-second", "TN⋅s", GiganewtonSecond, 1000.0);

   /// <summary>
   /// petanewton-second, defined as: teranewton-second × 1000.0
   /// </summary>
   public static readonly Momentum PetanewtonSecond = new ("petanewton-second", "PN⋅s", TeranewtonSecond, 1000.0);

   /// <summary>
   /// exanewton-second, defined as: petanewton-second × 1000.0
   /// </summary>
   public static readonly Momentum ExanewtonSecond = new ("exanewton-second", "EN⋅s", PetanewtonSecond, 1000.0);

   /// <summary>
   /// zettanewton-second, defined as: exanewton-second × 1000.0
   /// </summary>
   public static readonly Momentum ZettanewtonSecond = new ("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000.0);

   /// <summary>
   /// yottanewton-second, defined as: zettanewton-second × 1000.0
   /// </summary>
   public static readonly Momentum YottanewtonSecond = new ("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000.0);

   /// <summary>
   /// ronnanewton-second, defined as: yottanewton-second × 1000.0
   /// </summary>
   public static readonly Momentum RonnanewtonSecond = new ("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000.0);

   /// <summary>
   /// quettanewton-second, defined as: ronnanewton-second × 1000.0
   /// </summary>
   public static readonly Momentum QuettanewtonSecond = new ("quettanewton-second", "QN⋅s", RonnanewtonSecond, 1000.0);
}
