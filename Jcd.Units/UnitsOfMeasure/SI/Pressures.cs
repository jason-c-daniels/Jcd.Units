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
   public static readonly Pressure Pascal = new("pascal", "Pa", system: "SI");
   
   /// <summary>
   /// decipascal defined such that: pascal = dPa × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Decipascal = new("decipascal", "dPa", Pascal, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centipascal defined such that: decipascal = cPa × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Centipascal = new("centipascal", "cPa", Decipascal, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millipascal defined such that: centipascal = mPa × 1.0/10.0.
   /// </summary>
   public static readonly Pressure Millipascal = new("millipascal", "mPa", Centipascal, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// micropascal defined such that: millipascal = μPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Micropascal = new("micropascal", "μPa", Millipascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanopascal defined such that: micropascal = nPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Nanopascal = new("nanopascal", "nPa", Micropascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picopascal defined such that: nanopascal = pPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Picopascal = new("picopascal", "pPa", Nanopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtopascal defined such that: picopascal = fPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Femtopascal = new("femtopascal", "fPa", Picopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attopascal defined such that: femtopascal = aPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Attopascal = new("attopascal", "aPa", Femtopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptopascal defined such that: attopascal = zPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Zeptopascal = new("zeptopascal", "zPa", Attopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctopascal defined such that: zeptopascal = yPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Yoctopascal = new("yoctopascal", "yPa", Zeptopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontopascal defined such that: yoctopascal = rPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Rontopascal = new("rontopascal", "rPa", Yoctopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectopascal defined such that: rontopascal = qPa × 1.0/1000.0.
   /// </summary>
   public static readonly Pressure Quectopascal = new("quectopascal", "qPa", Rontopascal, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekapascal defined such that: pascal = daPa × 10.0.
   /// </summary>
   public static readonly Pressure Dekapascal = new("dekapascal", "daPa", Pascal, 10.0, system: "SI");
   
   /// <summary>
   /// hectopascal defined such that: dekapascal = hPa × 10.0.
   /// </summary>
   public static readonly Pressure Hectopascal = new("hectopascal", "hPa", Dekapascal, 10.0, system: "SI");
   
   /// <summary>
   /// kilopascal defined such that: hectopascal = kPa × 10.0.
   /// </summary>
   public static readonly Pressure Kilopascal = new("kilopascal", "kPa", Hectopascal, 10.0, system: "SI");
   
   /// <summary>
   /// megapascal defined such that: kilopascal = MPa × 1000.0.
   /// </summary>
   public static readonly Pressure Megapascal = new("megapascal", "MPa", Kilopascal, 1000.0, system: "SI");
   
   /// <summary>
   /// gigapascal defined such that: megapascal = GPa × 1000.0.
   /// </summary>
   public static readonly Pressure Gigapascal = new("gigapascal", "GPa", Megapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// terapascal defined such that: gigapascal = TPa × 1000.0.
   /// </summary>
   public static readonly Pressure Terapascal = new("terapascal", "TPa", Gigapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// petapascal defined such that: terapascal = PPa × 1000.0.
   /// </summary>
   public static readonly Pressure Petapascal = new("petapascal", "PPa", Terapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// exapascal defined such that: petapascal = EPa × 1000.0.
   /// </summary>
   public static readonly Pressure Exapascal = new("exapascal", "EPa", Petapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// zettapascal defined such that: exapascal = ZPa × 1000.0.
   /// </summary>
   public static readonly Pressure Zettapascal = new("zettapascal", "ZPa", Exapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// yottapascal defined such that: zettapascal = YPa × 1000.0.
   /// </summary>
   public static readonly Pressure Yottapascal = new("yottapascal", "YPa", Zettapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnapascal defined such that: yottapascal = RPa × 1000.0.
   /// </summary>
   public static readonly Pressure Ronnapascal = new("ronnapascal", "RPa", Yottapascal, 1000.0, system: "SI");
   
   /// <summary>
   /// quettapascal defined such that: ronnapascal = QPa × 1000.0.
   /// </summary>
   public static readonly Pressure Quettapascal = new("quettapascal", "QPa", Ronnapascal, 1000.0, system: "SI");
}