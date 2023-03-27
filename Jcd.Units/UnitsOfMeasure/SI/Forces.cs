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
/// International System of Units for measuring Force.
/// </summary>
public class Forces : UnitOfMeasureEnumeration<Forces, Force>
{
   /// <summary>
   /// A(n) newton.
   /// </summary>
   public static readonly Force Newton = new ("newton", "N");

   /// <summary>
   /// A(n) decinewton. Defined as: (1.0/10.0) × newton + (0).
   /// </summary>
   public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centinewton. Defined as: (1.0/10.0) × decinewton + (0).
   /// </summary>
   public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millinewton. Defined as: (1.0/10.0) × centinewton + (0).
   /// </summary>
   public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) micronewton. Defined as: (1.0/1000.0) × millinewton + (0).
   /// </summary>
   public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanonewton. Defined as: (1.0/1000.0) × micronewton + (0).
   /// </summary>
   public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) piconewton. Defined as: (1.0/1000.0) × nanonewton + (0).
   /// </summary>
   public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtonewton. Defined as: (1.0/1000.0) × piconewton + (0).
   /// </summary>
   public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attonewton. Defined as: (1.0/1000.0) × femtonewton + (0).
   /// </summary>
   public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptonewton. Defined as: (1.0/1000.0) × attonewton + (0).
   /// </summary>
   public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctonewton. Defined as: (1.0/1000.0) × zeptonewton + (0).
   /// </summary>
   public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontonewton. Defined as: (1.0/1000.0) × yoctonewton + (0).
   /// </summary>
   public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectonewton. Defined as: (1.0/1000.0) × rontonewton + (0).
   /// </summary>
   public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekanewton. Defined as: (10.0) × newton + (0).
   /// </summary>
   public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10.0, 0);

   /// <summary>
   /// A(n) hectonewton. Defined as: (10.0) × dekanewton + (0).
   /// </summary>
   public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10.0, 0);

   /// <summary>
   /// A(n) kilonewton. Defined as: (10.0) × hectonewton + (0).
   /// </summary>
   public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10.0, 0);

   /// <summary>
   /// A(n) meganewton. Defined as: (1000.0) × kilonewton + (0).
   /// </summary>
   public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000.0, 0);

   /// <summary>
   /// A(n) giganewton. Defined as: (1000.0) × meganewton + (0).
   /// </summary>
   public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000.0, 0);

   /// <summary>
   /// A(n) teranewton. Defined as: (1000.0) × giganewton + (0).
   /// </summary>
   public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000.0, 0);

   /// <summary>
   /// A(n) petanewton. Defined as: (1000.0) × teranewton + (0).
   /// </summary>
   public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000.0, 0);

   /// <summary>
   /// A(n) exanewton. Defined as: (1000.0) × petanewton + (0).
   /// </summary>
   public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000.0, 0);

   /// <summary>
   /// A(n) zettanewton. Defined as: (1000.0) × exanewton + (0).
   /// </summary>
   public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000.0, 0);

   /// <summary>
   /// A(n) yottanewton. Defined as: (1000.0) × zettanewton + (0).
   /// </summary>
   public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000.0, 0);

   /// <summary>
   /// A(n) ronnanewton. Defined as: (1000.0) × yottanewton + (0).
   /// </summary>
   public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000.0, 0);

   /// <summary>
   /// A(n) quettanewton. Defined as: (1000.0) × ronnanewton + (0).
   /// </summary>
   public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000.0, 0);
}
