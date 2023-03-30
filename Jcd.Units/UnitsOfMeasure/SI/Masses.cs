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
/// International System of Units for measuring Mass.
/// </summary>
public class Masses : UnitOfMeasureEnumeration<Masses, Mass>
{
   /// <summary>
   /// A(n) kilogram.
   /// </summary>
   public static readonly Mass Kilogram = new ("kilogram", "kg");

   /// <summary>
   /// A(n) hectogram. Defined as: 1.0/10.0 × kilogram.
   /// </summary>
   public static readonly Mass Hectogram = new ("hectogram", "hg", Kilogram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) dekagram. Defined as: 1.0/10.0 × hectogram.
   /// </summary>
   public static readonly Mass Dekagram = new ("dekagram", "dag", Hectogram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) gram. Defined as: 1.0/10.0 × dekagram.
   /// </summary>
   public static readonly Mass Gram = new ("gram", "g", Dekagram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) decigram. Defined as: 1.0/10.0 × gram.
   /// </summary>
   public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centigram. Defined as: 1.0/10.0 × decigram.
   /// </summary>
   public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) milligram. Defined as: 1.0/10.0 × centigram.
   /// </summary>
   public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microgram. Defined as: 1.0/1000.0 × milligram.
   /// </summary>
   public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanogram. Defined as: 1.0/1000.0 × microgram.
   /// </summary>
   public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picogram. Defined as: 1.0/1000.0 × nanogram.
   /// </summary>
   public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtogram. Defined as: 1.0/1000.0 × picogram.
   /// </summary>
   public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attogram. Defined as: 1.0/1000.0 × femtogram.
   /// </summary>
   public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptogram. Defined as: 1.0/1000.0 × attogram.
   /// </summary>
   public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctogram. Defined as: 1.0/1000.0 × zeptogram.
   /// </summary>
   public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontogram. Defined as: 1.0/1000.0 × yoctogram.
   /// </summary>
   public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectogram. Defined as: 1.0/1000.0 × rontogram.
   /// </summary>
   public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) megagram. Defined as: 1000.0 × kilogram.
   /// </summary>
   public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000.0, 0);

   /// <summary>
   /// A(n) gigagram. Defined as: 1000.0 × megagram.
   /// </summary>
   public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000.0, 0);

   /// <summary>
   /// A(n) teragram. Defined as: 1000.0 × gigagram.
   /// </summary>
   public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000.0, 0);

   /// <summary>
   /// A(n) petagram. Defined as: 1000.0 × teragram.
   /// </summary>
   public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000.0, 0);

   /// <summary>
   /// A(n) exagram. Defined as: 1000.0 × petagram.
   /// </summary>
   public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000.0, 0);

   /// <summary>
   /// A(n) zettagram. Defined as: 1000.0 × exagram.
   /// </summary>
   public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000.0, 0);

   /// <summary>
   /// A(n) yottagram. Defined as: 1000.0 × zettagram.
   /// </summary>
   public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000.0, 0);

   /// <summary>
   /// A(n) ronnagram. Defined as: 1000.0 × yottagram.
   /// </summary>
   public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000.0, 0);

   /// <summary>
   /// A(n) quettagram. Defined as: 1000.0 × ronnagram.
   /// </summary>
   public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000.0, 0);

   /// <summary>
   /// A(n) metric ton. Defined as: 1.0 × megagram.
   /// </summary>
   public static readonly Mass MetricTon = new ("metric ton", "mt", Megagram, 1.0, 0);
}
