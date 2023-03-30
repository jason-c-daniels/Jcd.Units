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
   /// newton, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Force Newton = new ("newton", "N");

   /// <summary>
   /// decinewton, defined as: newton × 1.0/10.0
   /// </summary>
   public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0 / 10.0);

   /// <summary>
   /// centinewton, defined as: decinewton × 1.0/10.0
   /// </summary>
   public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0 / 10.0);

   /// <summary>
   /// millinewton, defined as: centinewton × 1.0/10.0
   /// </summary>
   public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0 / 10.0);

   /// <summary>
   /// micronewton, defined as: millinewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0 / 1000.0);

   /// <summary>
   /// nanonewton, defined as: micronewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0 / 1000.0);

   /// <summary>
   /// piconewton, defined as: nanonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0 / 1000.0);

   /// <summary>
   /// femtonewton, defined as: piconewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0 / 1000.0);

   /// <summary>
   /// attonewton, defined as: femtonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0 / 1000.0);

   /// <summary>
   /// zeptonewton, defined as: attonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0 / 1000.0);

   /// <summary>
   /// yoctonewton, defined as: zeptonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0 / 1000.0);

   /// <summary>
   /// rontonewton, defined as: yoctonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0 / 1000.0);

   /// <summary>
   /// quectonewton, defined as: rontonewton × 1.0/1000.0
   /// </summary>
   public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0 / 1000.0);

   /// <summary>
   /// dekanewton, defined as: newton × 10.0
   /// </summary>
   public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10.0);

   /// <summary>
   /// hectonewton, defined as: dekanewton × 10.0
   /// </summary>
   public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10.0);

   /// <summary>
   /// kilonewton, defined as: hectonewton × 10.0
   /// </summary>
   public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10.0);

   /// <summary>
   /// meganewton, defined as: kilonewton × 1000.0
   /// </summary>
   public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000.0);

   /// <summary>
   /// giganewton, defined as: meganewton × 1000.0
   /// </summary>
   public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000.0);

   /// <summary>
   /// teranewton, defined as: giganewton × 1000.0
   /// </summary>
   public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000.0);

   /// <summary>
   /// petanewton, defined as: teranewton × 1000.0
   /// </summary>
   public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000.0);

   /// <summary>
   /// exanewton, defined as: petanewton × 1000.0
   /// </summary>
   public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000.0);

   /// <summary>
   /// zettanewton, defined as: exanewton × 1000.0
   /// </summary>
   public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000.0);

   /// <summary>
   /// yottanewton, defined as: zettanewton × 1000.0
   /// </summary>
   public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000.0);

   /// <summary>
   /// ronnanewton, defined as: yottanewton × 1000.0
   /// </summary>
   public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000.0);

   /// <summary>
   /// quettanewton, defined as: ronnanewton × 1000.0
   /// </summary>
   public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000.0);
}
