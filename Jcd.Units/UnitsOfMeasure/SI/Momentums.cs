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
   /// A(n) newton-second.
   /// </summary>
   public static readonly Momentum NewtonSecond = new ("newton-second", "N⋅s");

   /// <summary>
   /// A(n) decinewton-second. Defined as: (1.0/10.0) × newton-second + (0).
   /// </summary>
   public static readonly Momentum DecinewtonSecond = new ("decinewton-second", "dN⋅s", NewtonSecond, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centinewton-second. Defined as: (1.0/10.0) × decinewton-second + (0).
   /// </summary>
   public static readonly Momentum CentinewtonSecond = new (
                                                            "centinewton-second"
                                                          , "cN⋅s"
                                                          , DecinewtonSecond
                                                          , 1.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) millinewton-second. Defined as: (1.0/10.0) × centinewton-second + (0).
   /// </summary>
   public static readonly Momentum MillinewtonSecond = new (
                                                            "millinewton-second"
                                                          , "mN⋅s"
                                                          , CentinewtonSecond
                                                          , 1.0 / 10.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) micronewton-second. Defined as: (1.0/1000.0) × millinewton-second + (0).
   /// </summary>
   public static readonly Momentum MicronewtonSecond = new (
                                                            "micronewton-second"
                                                          , "μN⋅s"
                                                          , MillinewtonSecond
                                                          , 1.0 / 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) nanonewton-second. Defined as: (1.0/1000.0) × micronewton-second + (0).
   /// </summary>
   public static readonly Momentum NanonewtonSecond = new (
                                                           "nanonewton-second"
                                                         , "nN⋅s"
                                                         , MicronewtonSecond
                                                         , 1.0 / 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) piconewton-second. Defined as: (1.0/1000.0) × nanonewton-second + (0).
   /// </summary>
   public static readonly Momentum PiconewtonSecond = new (
                                                           "piconewton-second"
                                                         , "pN⋅s"
                                                         , NanonewtonSecond
                                                         , 1.0 / 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) femtonewton-second. Defined as: (1.0/1000.0) × piconewton-second + (0).
   /// </summary>
   public static readonly Momentum FemtonewtonSecond = new (
                                                            "femtonewton-second"
                                                          , "fN⋅s"
                                                          , PiconewtonSecond
                                                          , 1.0 / 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) attonewton-second. Defined as: (1.0/1000.0) × femtonewton-second + (0).
   /// </summary>
   public static readonly Momentum AttonewtonSecond = new (
                                                           "attonewton-second"
                                                         , "aN⋅s"
                                                         , FemtonewtonSecond
                                                         , 1.0 / 1000.0
                                                         , 0
                                                          );

   /// <summary>
   /// A(n) zeptonewton-second. Defined as: (1.0/1000.0) × attonewton-second + (0).
   /// </summary>
   public static readonly Momentum ZeptonewtonSecond = new (
                                                            "zeptonewton-second"
                                                          , "zN⋅s"
                                                          , AttonewtonSecond
                                                          , 1.0 / 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) yoctonewton-second. Defined as: (1.0/1000.0) × zeptonewton-second + (0).
   /// </summary>
   public static readonly Momentum YoctonewtonSecond = new (
                                                            "yoctonewton-second"
                                                          , "yN⋅s"
                                                          , ZeptonewtonSecond
                                                          , 1.0 / 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) rontonewton-second. Defined as: (1.0/1000.0) × yoctonewton-second + (0).
   /// </summary>
   public static readonly Momentum RontonewtonSecond = new (
                                                            "rontonewton-second"
                                                          , "rN⋅s"
                                                          , YoctonewtonSecond
                                                          , 1.0 / 1000.0
                                                          , 0
                                                           );

   /// <summary>
   /// A(n) quectonewton-second. Defined as: (1.0/1000.0) × rontonewton-second + (0).
   /// </summary>
   public static readonly Momentum QuectonewtonSecond = new (
                                                             "quectonewton-second"
                                                           , "qN⋅s"
                                                           , RontonewtonSecond
                                                           , 1.0 / 1000.0
                                                           , 0
                                                            );

   /// <summary>
   /// A(n) dekanewton-second. Defined as: (10.0) × newton-second + (0).
   /// </summary>
   public static readonly Momentum DekanewtonSecond = new ("dekanewton-second", "daN⋅s", NewtonSecond, 10.0, 0);

   /// <summary>
   /// A(n) hectonewton-second. Defined as: (10.0) × dekanewton-second + (0).
   /// </summary>
   public static readonly Momentum HectonewtonSecond = new ("hectonewton-second", "hN⋅s", DekanewtonSecond, 10.0, 0);

   /// <summary>
   /// A(n) kilonewton-second. Defined as: (10.0) × hectonewton-second + (0).
   /// </summary>
   public static readonly Momentum KilonewtonSecond = new ("kilonewton-second", "kN⋅s", HectonewtonSecond, 10.0, 0);

   /// <summary>
   /// A(n) meganewton-second. Defined as: (1000.0) × kilonewton-second + (0).
   /// </summary>
   public static readonly Momentum MeganewtonSecond = new ("meganewton-second", "MN⋅s", KilonewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) giganewton-second. Defined as: (1000.0) × meganewton-second + (0).
   /// </summary>
   public static readonly Momentum GiganewtonSecond = new ("giganewton-second", "GN⋅s", MeganewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) teranewton-second. Defined as: (1000.0) × giganewton-second + (0).
   /// </summary>
   public static readonly Momentum TeranewtonSecond = new ("teranewton-second", "TN⋅s", GiganewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) petanewton-second. Defined as: (1000.0) × teranewton-second + (0).
   /// </summary>
   public static readonly Momentum PetanewtonSecond = new ("petanewton-second", "PN⋅s", TeranewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) exanewton-second. Defined as: (1000.0) × petanewton-second + (0).
   /// </summary>
   public static readonly Momentum ExanewtonSecond = new ("exanewton-second", "EN⋅s", PetanewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) zettanewton-second. Defined as: (1000.0) × exanewton-second + (0).
   /// </summary>
   public static readonly Momentum ZettanewtonSecond = new ("zettanewton-second", "ZN⋅s", ExanewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) yottanewton-second. Defined as: (1000.0) × zettanewton-second + (0).
   /// </summary>
   public static readonly Momentum YottanewtonSecond = new ("yottanewton-second", "YN⋅s", ZettanewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) ronnanewton-second. Defined as: (1000.0) × yottanewton-second + (0).
   /// </summary>
   public static readonly Momentum RonnanewtonSecond = new ("ronnanewton-second", "RN⋅s", YottanewtonSecond, 1000.0, 0);

   /// <summary>
   /// A(n) quettanewton-second. Defined as: (1000.0) × ronnanewton-second + (0).
   /// </summary>
   public static readonly Momentum QuettanewtonSecond = new (
                                                             "quettanewton-second"
                                                           , "QN⋅s"
                                                           , RonnanewtonSecond
                                                           , 1000.0
                                                           , 0
                                                            );
}
