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
/// International System of Units for measuring Radioactive Decay.
/// </summary>
public class RadioactiveDecays : UnitOfMeasureEnumeration<RadioactiveDecays, RadioactiveDecay>
{
   /// <summary>
   /// A(n) becquerel.
   /// </summary>
   public static readonly RadioactiveDecay Becquerel = new ("becquerel", "Bq");

   /// <summary>
   /// A(n) decibecquerel. Defined as: (1.0/10.0) × becquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centibecquerel. Defined as: (1.0/10.0) × decibecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millibecquerel. Defined as: (1.0/10.0) × centibecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay
            Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microbecquerel. Defined as: (1.0/1000.0) × millibecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Microbecquerel = new (
                                                                 "microbecquerel"
                                                               , "μBq"
                                                               , Millibecquerel
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) nanobecquerel. Defined as: (1.0/1000.0) × microbecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay
            Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picobecquerel. Defined as: (1.0/1000.0) × nanobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtobecquerel. Defined as: (1.0/1000.0) × picobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Femtobecquerel = new (
                                                                 "femtobecquerel"
                                                               , "fBq"
                                                               , Picobecquerel
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) attobecquerel. Defined as: (1.0/1000.0) × femtobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay
            Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptobecquerel. Defined as: (1.0/1000.0) × attobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Zeptobecquerel = new (
                                                                 "zeptobecquerel"
                                                               , "zBq"
                                                               , Attobecquerel
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) yoctobecquerel. Defined as: (1.0/1000.0) × zeptobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Yoctobecquerel = new (
                                                                 "yoctobecquerel"
                                                               , "yBq"
                                                               , Zeptobecquerel
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) rontobecquerel. Defined as: (1.0/1000.0) × yoctobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Rontobecquerel = new (
                                                                 "rontobecquerel"
                                                               , "rBq"
                                                               , Yoctobecquerel
                                                               , 1.0 / 1000.0
                                                               , 0
                                                                );

   /// <summary>
   /// A(n) quectobecquerel. Defined as: (1.0/1000.0) × rontobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Quectobecquerel = new (
                                                                  "quectobecquerel"
                                                                , "qBq"
                                                                , Rontobecquerel
                                                                , 1.0 / 1000.0
                                                                , 0
                                                                 );

   /// <summary>
   /// A(n) dekabecquerel. Defined as: (10.0) × becquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10.0, 0);

   /// <summary>
   /// A(n) hectobecquerel. Defined as: (10.0) × dekabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10.0, 0);

   /// <summary>
   /// A(n) kilobecquerel. Defined as: (10.0) × hectobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10.0, 0);

   /// <summary>
   /// A(n) megabecquerel. Defined as: (1000.0) × kilobecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) gigabecquerel. Defined as: (1000.0) × megabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) terabecquerel. Defined as: (1000.0) × gigabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) petabecquerel. Defined as: (1000.0) × terabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) exabecquerel. Defined as: (1000.0) × petabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) zettabecquerel. Defined as: (1000.0) × exabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) yottabecquerel. Defined as: (1000.0) × zettabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) ronnabecquerel. Defined as: (1000.0) × yottabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000.0, 0);

   /// <summary>
   /// A(n) quettabecquerel. Defined as: (1000.0) × ronnabecquerel + (0).
   /// </summary>
   public static readonly RadioactiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000.0, 0);
}
