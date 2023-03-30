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
/// International System of Units for measuring Pressure.
/// </summary>
public class Pressures : UnitOfMeasureEnumeration<Pressures, Pressure>
{
   /// <summary>
   /// pascal, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Pressure Pascal = new ("pascal", "Pa");

   /// <summary>
   /// decipascal, defined as: pascal × 1.0/10.0
   /// </summary>
   public static readonly Pressure Decipascal = new ("decipascal", "dPa", Pascal, 1.0 / 10.0);

   /// <summary>
   /// centipascal, defined as: decipascal × 1.0/10.0
   /// </summary>
   public static readonly Pressure Centipascal = new ("centipascal", "cPa", Decipascal, 1.0 / 10.0);

   /// <summary>
   /// millipascal, defined as: centipascal × 1.0/10.0
   /// </summary>
   public static readonly Pressure Millipascal = new ("millipascal", "mPa", Centipascal, 1.0 / 10.0);

   /// <summary>
   /// micropascal, defined as: millipascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Micropascal = new ("micropascal", "μPa", Millipascal, 1.0 / 1000.0);

   /// <summary>
   /// nanopascal, defined as: micropascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Nanopascal = new ("nanopascal", "nPa", Micropascal, 1.0 / 1000.0);

   /// <summary>
   /// picopascal, defined as: nanopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Picopascal = new ("picopascal", "pPa", Nanopascal, 1.0 / 1000.0);

   /// <summary>
   /// femtopascal, defined as: picopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Femtopascal = new ("femtopascal", "fPa", Picopascal, 1.0 / 1000.0);

   /// <summary>
   /// attopascal, defined as: femtopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Attopascal = new ("attopascal", "aPa", Femtopascal, 1.0 / 1000.0);

   /// <summary>
   /// zeptopascal, defined as: attopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Zeptopascal = new ("zeptopascal", "zPa", Attopascal, 1.0 / 1000.0);

   /// <summary>
   /// yoctopascal, defined as: zeptopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Yoctopascal = new ("yoctopascal", "yPa", Zeptopascal, 1.0 / 1000.0);

   /// <summary>
   /// rontopascal, defined as: yoctopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Rontopascal = new ("rontopascal", "rPa", Yoctopascal, 1.0 / 1000.0);

   /// <summary>
   /// quectopascal, defined as: rontopascal × 1.0/1000.0
   /// </summary>
   public static readonly Pressure Quectopascal = new ("quectopascal", "qPa", Rontopascal, 1.0 / 1000.0);

   /// <summary>
   /// dekapascal, defined as: pascal × 10.0
   /// </summary>
   public static readonly Pressure Dekapascal = new ("dekapascal", "daPa", Pascal, 10.0);

   /// <summary>
   /// hectopascal, defined as: dekapascal × 10.0
   /// </summary>
   public static readonly Pressure Hectopascal = new ("hectopascal", "hPa", Dekapascal, 10.0);

   /// <summary>
   /// kilopascal, defined as: hectopascal × 10.0
   /// </summary>
   public static readonly Pressure Kilopascal = new ("kilopascal", "kPa", Hectopascal, 10.0);

   /// <summary>
   /// megapascal, defined as: kilopascal × 1000.0
   /// </summary>
   public static readonly Pressure Megapascal = new ("megapascal", "MPa", Kilopascal, 1000.0);

   /// <summary>
   /// gigapascal, defined as: megapascal × 1000.0
   /// </summary>
   public static readonly Pressure Gigapascal = new ("gigapascal", "GPa", Megapascal, 1000.0);

   /// <summary>
   /// terapascal, defined as: gigapascal × 1000.0
   /// </summary>
   public static readonly Pressure Terapascal = new ("terapascal", "TPa", Gigapascal, 1000.0);

   /// <summary>
   /// petapascal, defined as: terapascal × 1000.0
   /// </summary>
   public static readonly Pressure Petapascal = new ("petapascal", "PPa", Terapascal, 1000.0);

   /// <summary>
   /// exapascal, defined as: petapascal × 1000.0
   /// </summary>
   public static readonly Pressure Exapascal = new ("exapascal", "EPa", Petapascal, 1000.0);

   /// <summary>
   /// zettapascal, defined as: exapascal × 1000.0
   /// </summary>
   public static readonly Pressure Zettapascal = new ("zettapascal", "ZPa", Exapascal, 1000.0);

   /// <summary>
   /// yottapascal, defined as: zettapascal × 1000.0
   /// </summary>
   public static readonly Pressure Yottapascal = new ("yottapascal", "YPa", Zettapascal, 1000.0);

   /// <summary>
   /// ronnapascal, defined as: yottapascal × 1000.0
   /// </summary>
   public static readonly Pressure Ronnapascal = new ("ronnapascal", "RPa", Yottapascal, 1000.0);

   /// <summary>
   /// quettapascal, defined as: ronnapascal × 1000.0
   /// </summary>
   public static readonly Pressure Quettapascal = new ("quettapascal", "QPa", Ronnapascal, 1000.0);
}
