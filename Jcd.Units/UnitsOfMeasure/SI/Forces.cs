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
   public static readonly Force Newton = new ("newton", "N", system: "SI");

   /// <summary>
   /// decinewton defined such that: newton = dN × 1.0/10.0.
   /// </summary>
   public static readonly Force Decinewton = new ("decinewton", "dN", Newton, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centinewton defined such that: decinewton = cN × 1.0/10.0.
   /// </summary>
   public static readonly Force Centinewton = new ("centinewton", "cN", Decinewton, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millinewton defined such that: centinewton = mN × 1.0/10.0.
   /// </summary>
   public static readonly Force Millinewton = new ("millinewton", "mN", Centinewton, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// micronewton defined such that: millinewton = μN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Micronewton = new ("micronewton", "μN", Millinewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanonewton defined such that: micronewton = nN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Nanonewton = new ("nanonewton", "nN", Micronewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// piconewton defined such that: nanonewton = pN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Piconewton = new ("piconewton", "pN", Nanonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtonewton defined such that: piconewton = fN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Femtonewton = new ("femtonewton", "fN", Piconewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attonewton defined such that: femtonewton = aN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Attonewton = new ("attonewton", "aN", Femtonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptonewton defined such that: attonewton = zN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Zeptonewton = new ("zeptonewton", "zN", Attonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctonewton defined such that: zeptonewton = yN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Yoctonewton = new ("yoctonewton", "yN", Zeptonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontonewton defined such that: yoctonewton = rN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Rontonewton = new ("rontonewton", "rN", Yoctonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectonewton defined such that: rontonewton = qN × 1.0/1000.0.
   /// </summary>
   public static readonly Force Quectonewton = new ("quectonewton", "qN", Rontonewton, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekanewton defined such that: newton = daN × 10.0.
   /// </summary>
   public static readonly Force Dekanewton = new ("dekanewton", "daN", Newton, 10.0, system: "SI");

   /// <summary>
   /// hectonewton defined such that: dekanewton = hN × 10.0.
   /// </summary>
   public static readonly Force Hectonewton = new ("hectonewton", "hN", Dekanewton, 10.0, system: "SI");

   /// <summary>
   /// kilonewton defined such that: hectonewton = kN × 10.0.
   /// </summary>
   public static readonly Force Kilonewton = new ("kilonewton", "kN", Hectonewton, 10.0, system: "SI");

   /// <summary>
   /// meganewton defined such that: kilonewton = MN × 1000.0.
   /// </summary>
   public static readonly Force Meganewton = new ("meganewton", "MN", Kilonewton, 1000.0, system: "SI");

   /// <summary>
   /// giganewton defined such that: meganewton = GN × 1000.0.
   /// </summary>
   public static readonly Force Giganewton = new ("giganewton", "GN", Meganewton, 1000.0, system: "SI");

   /// <summary>
   /// teranewton defined such that: giganewton = TN × 1000.0.
   /// </summary>
   public static readonly Force Teranewton = new ("teranewton", "TN", Giganewton, 1000.0, system: "SI");

   /// <summary>
   /// petanewton defined such that: teranewton = PN × 1000.0.
   /// </summary>
   public static readonly Force Petanewton = new ("petanewton", "PN", Teranewton, 1000.0, system: "SI");

   /// <summary>
   /// exanewton defined such that: petanewton = EN × 1000.0.
   /// </summary>
   public static readonly Force Exanewton = new ("exanewton", "EN", Petanewton, 1000.0, system: "SI");

   /// <summary>
   /// zettanewton defined such that: exanewton = ZN × 1000.0.
   /// </summary>
   public static readonly Force Zettanewton = new ("zettanewton", "ZN", Exanewton, 1000.0, system: "SI");

   /// <summary>
   /// yottanewton defined such that: zettanewton = YN × 1000.0.
   /// </summary>
   public static readonly Force Yottanewton = new ("yottanewton", "YN", Zettanewton, 1000.0, system: "SI");

   /// <summary>
   /// ronnanewton defined such that: yottanewton = RN × 1000.0.
   /// </summary>
   public static readonly Force Ronnanewton = new ("ronnanewton", "RN", Yottanewton, 1000.0, system: "SI");

   /// <summary>
   /// quettanewton defined such that: ronnanewton = QN × 1000.0.
   /// </summary>
   public static readonly Force Quettanewton = new ("quettanewton", "QN", Ronnanewton, 1000.0, system: "SI");
}
