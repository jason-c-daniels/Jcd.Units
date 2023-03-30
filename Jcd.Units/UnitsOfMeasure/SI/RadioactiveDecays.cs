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
   /// becquerel, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly RadioactiveDecay Becquerel = new ("becquerel", "Bq");

   /// <summary>
   /// decibecquerel, defined as: becquerel × 1.0/10.0
   /// </summary>
   public static readonly RadioactiveDecay Decibecquerel = new ("decibecquerel", "dBq", Becquerel, 1.0 / 10.0);

   /// <summary>
   /// centibecquerel, defined as: decibecquerel × 1.0/10.0
   /// </summary>
   public static readonly RadioactiveDecay Centibecquerel = new ("centibecquerel", "cBq", Decibecquerel, 1.0 / 10.0);

   /// <summary>
   /// millibecquerel, defined as: centibecquerel × 1.0/10.0
   /// </summary>
   public static readonly RadioactiveDecay Millibecquerel = new ("millibecquerel", "mBq", Centibecquerel, 1.0 / 10.0);

   /// <summary>
   /// microbecquerel, defined as: millibecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Microbecquerel = new ("microbecquerel", "μBq", Millibecquerel, 1.0 / 1000.0);

   /// <summary>
   /// nanobecquerel, defined as: microbecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Nanobecquerel = new ("nanobecquerel", "nBq", Microbecquerel, 1.0 / 1000.0);

   /// <summary>
   /// picobecquerel, defined as: nanobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Picobecquerel = new ("picobecquerel", "pBq", Nanobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// femtobecquerel, defined as: picobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Femtobecquerel = new ("femtobecquerel", "fBq", Picobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// attobecquerel, defined as: femtobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Attobecquerel = new ("attobecquerel", "aBq", Femtobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// zeptobecquerel, defined as: attobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Zeptobecquerel = new ("zeptobecquerel", "zBq", Attobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// yoctobecquerel, defined as: zeptobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Yoctobecquerel = new ("yoctobecquerel", "yBq", Zeptobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// rontobecquerel, defined as: yoctobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Rontobecquerel = new ("rontobecquerel", "rBq", Yoctobecquerel, 1.0 / 1000.0);

   /// <summary>
   /// quectobecquerel, defined as: rontobecquerel × 1.0/1000.0
   /// </summary>
   public static readonly RadioactiveDecay Quectobecquerel = new (
                                                                  "quectobecquerel"
                                                                , "qBq"
                                                                , Rontobecquerel
                                                                , 1.0 / 1000.0
                                                                 );

   /// <summary>
   /// dekabecquerel, defined as: becquerel × 10.0
   /// </summary>
   public static readonly RadioactiveDecay Dekabecquerel = new ("dekabecquerel", "daBq", Becquerel, 10.0);

   /// <summary>
   /// hectobecquerel, defined as: dekabecquerel × 10.0
   /// </summary>
   public static readonly RadioactiveDecay Hectobecquerel = new ("hectobecquerel", "hBq", Dekabecquerel, 10.0);

   /// <summary>
   /// kilobecquerel, defined as: hectobecquerel × 10.0
   /// </summary>
   public static readonly RadioactiveDecay Kilobecquerel = new ("kilobecquerel", "kBq", Hectobecquerel, 10.0);

   /// <summary>
   /// megabecquerel, defined as: kilobecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Megabecquerel = new ("megabecquerel", "MBq", Kilobecquerel, 1000.0);

   /// <summary>
   /// gigabecquerel, defined as: megabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Gigabecquerel = new ("gigabecquerel", "GBq", Megabecquerel, 1000.0);

   /// <summary>
   /// terabecquerel, defined as: gigabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Terabecquerel = new ("terabecquerel", "TBq", Gigabecquerel, 1000.0);

   /// <summary>
   /// petabecquerel, defined as: terabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Petabecquerel = new ("petabecquerel", "PBq", Terabecquerel, 1000.0);

   /// <summary>
   /// exabecquerel, defined as: petabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Exabecquerel = new ("exabecquerel", "EBq", Petabecquerel, 1000.0);

   /// <summary>
   /// zettabecquerel, defined as: exabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Zettabecquerel = new ("zettabecquerel", "ZBq", Exabecquerel, 1000.0);

   /// <summary>
   /// yottabecquerel, defined as: zettabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Yottabecquerel = new ("yottabecquerel", "YBq", Zettabecquerel, 1000.0);

   /// <summary>
   /// ronnabecquerel, defined as: yottabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Ronnabecquerel = new ("ronnabecquerel", "RBq", Yottabecquerel, 1000.0);

   /// <summary>
   /// quettabecquerel, defined as: ronnabecquerel × 1000.0
   /// </summary>
   public static readonly RadioactiveDecay Quettabecquerel = new ("quettabecquerel", "QBq", Ronnabecquerel, 1000.0);
}
