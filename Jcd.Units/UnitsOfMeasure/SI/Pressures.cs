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
   /// A(n) pascal.
   /// </summary>
   public static readonly Pressure Pascal = new ("pascal", "Pa");

   /// <summary>
   /// A(n) decipascal. Defined as: (1.0/10.0) × pascal + (0).
   /// </summary>
   public static readonly Pressure Decipascal = new ("decipascal", "dPa", Pascal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centipascal. Defined as: (1.0/10.0) × decipascal + (0).
   /// </summary>
   public static readonly Pressure Centipascal = new ("centipascal", "cPa", Decipascal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millipascal. Defined as: (1.0/10.0) × centipascal + (0).
   /// </summary>
   public static readonly Pressure Millipascal = new ("millipascal", "mPa", Centipascal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) micropascal. Defined as: (1.0/1000.0) × millipascal + (0).
   /// </summary>
   public static readonly Pressure Micropascal = new ("micropascal", "μPa", Millipascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanopascal. Defined as: (1.0/1000.0) × micropascal + (0).
   /// </summary>
   public static readonly Pressure Nanopascal = new ("nanopascal", "nPa", Micropascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picopascal. Defined as: (1.0/1000.0) × nanopascal + (0).
   /// </summary>
   public static readonly Pressure Picopascal = new ("picopascal", "pPa", Nanopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtopascal. Defined as: (1.0/1000.0) × picopascal + (0).
   /// </summary>
   public static readonly Pressure Femtopascal = new ("femtopascal", "fPa", Picopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attopascal. Defined as: (1.0/1000.0) × femtopascal + (0).
   /// </summary>
   public static readonly Pressure Attopascal = new ("attopascal", "aPa", Femtopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptopascal. Defined as: (1.0/1000.0) × attopascal + (0).
   /// </summary>
   public static readonly Pressure Zeptopascal = new ("zeptopascal", "zPa", Attopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctopascal. Defined as: (1.0/1000.0) × zeptopascal + (0).
   /// </summary>
   public static readonly Pressure Yoctopascal = new ("yoctopascal", "yPa", Zeptopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontopascal. Defined as: (1.0/1000.0) × yoctopascal + (0).
   /// </summary>
   public static readonly Pressure Rontopascal = new ("rontopascal", "rPa", Yoctopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectopascal. Defined as: (1.0/1000.0) × rontopascal + (0).
   /// </summary>
   public static readonly Pressure Quectopascal = new ("quectopascal", "qPa", Rontopascal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekapascal. Defined as: (10.0) × pascal + (0).
   /// </summary>
   public static readonly Pressure Dekapascal = new ("dekapascal", "daPa", Pascal, 10.0, 0);

   /// <summary>
   /// A(n) hectopascal. Defined as: (10.0) × dekapascal + (0).
   /// </summary>
   public static readonly Pressure Hectopascal = new ("hectopascal", "hPa", Dekapascal, 10.0, 0);

   /// <summary>
   /// A(n) kilopascal. Defined as: (10.0) × hectopascal + (0).
   /// </summary>
   public static readonly Pressure Kilopascal = new ("kilopascal", "kPa", Hectopascal, 10.0, 0);

   /// <summary>
   /// A(n) megapascal. Defined as: (1000.0) × kilopascal + (0).
   /// </summary>
   public static readonly Pressure Megapascal = new ("megapascal", "MPa", Kilopascal, 1000.0, 0);

   /// <summary>
   /// A(n) gigapascal. Defined as: (1000.0) × megapascal + (0).
   /// </summary>
   public static readonly Pressure Gigapascal = new ("gigapascal", "GPa", Megapascal, 1000.0, 0);

   /// <summary>
   /// A(n) terapascal. Defined as: (1000.0) × gigapascal + (0).
   /// </summary>
   public static readonly Pressure Terapascal = new ("terapascal", "TPa", Gigapascal, 1000.0, 0);

   /// <summary>
   /// A(n) petapascal. Defined as: (1000.0) × terapascal + (0).
   /// </summary>
   public static readonly Pressure Petapascal = new ("petapascal", "PPa", Terapascal, 1000.0, 0);

   /// <summary>
   /// A(n) exapascal. Defined as: (1000.0) × petapascal + (0).
   /// </summary>
   public static readonly Pressure Exapascal = new ("exapascal", "EPa", Petapascal, 1000.0, 0);

   /// <summary>
   /// A(n) zettapascal. Defined as: (1000.0) × exapascal + (0).
   /// </summary>
   public static readonly Pressure Zettapascal = new ("zettapascal", "ZPa", Exapascal, 1000.0, 0);

   /// <summary>
   /// A(n) yottapascal. Defined as: (1000.0) × zettapascal + (0).
   /// </summary>
   public static readonly Pressure Yottapascal = new ("yottapascal", "YPa", Zettapascal, 1000.0, 0);

   /// <summary>
   /// A(n) ronnapascal. Defined as: (1000.0) × yottapascal + (0).
   /// </summary>
   public static readonly Pressure Ronnapascal = new ("ronnapascal", "RPa", Yottapascal, 1000.0, 0);

   /// <summary>
   /// A(n) quettapascal. Defined as: (1000.0) × ronnapascal + (0).
   /// </summary>
   public static readonly Pressure Quettapascal = new ("quettapascal", "QPa", Ronnapascal, 1000.0, 0);
}
