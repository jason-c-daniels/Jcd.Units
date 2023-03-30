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
   /// kilogram, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Mass Kilogram = new ("kilogram", "kg");

   /// <summary>
   /// hectogram, defined as: kilogram × 1.0/10.0
   /// </summary>
   public static readonly Mass Hectogram = new ("hectogram", "hg", Kilogram, 1.0 / 10.0);

   /// <summary>
   /// dekagram, defined as: hectogram × 1.0/10.0
   /// </summary>
   public static readonly Mass Dekagram = new ("dekagram", "dag", Hectogram, 1.0 / 10.0);

   /// <summary>
   /// gram, defined as: dekagram × 1.0/10.0
   /// </summary>
   public static readonly Mass Gram = new ("gram", "g", Dekagram, 1.0 / 10.0);

   /// <summary>
   /// decigram, defined as: gram × 1.0/10.0
   /// </summary>
   public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0 / 10.0);

   /// <summary>
   /// centigram, defined as: decigram × 1.0/10.0
   /// </summary>
   public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0 / 10.0);

   /// <summary>
   /// milligram, defined as: centigram × 1.0/10.0
   /// </summary>
   public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0 / 10.0);

   /// <summary>
   /// microgram, defined as: milligram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0 / 1000.0);

   /// <summary>
   /// nanogram, defined as: microgram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0 / 1000.0);

   /// <summary>
   /// picogram, defined as: nanogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0 / 1000.0);

   /// <summary>
   /// femtogram, defined as: picogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0 / 1000.0);

   /// <summary>
   /// attogram, defined as: femtogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0 / 1000.0);

   /// <summary>
   /// zeptogram, defined as: attogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0 / 1000.0);

   /// <summary>
   /// yoctogram, defined as: zeptogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0 / 1000.0);

   /// <summary>
   /// rontogram, defined as: yoctogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0 / 1000.0);

   /// <summary>
   /// quectogram, defined as: rontogram × 1.0/1000.0
   /// </summary>
   public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0 / 1000.0);

   /// <summary>
   /// megagram, defined as: kilogram × 1000.0
   /// </summary>
   public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000.0);

   /// <summary>
   /// gigagram, defined as: megagram × 1000.0
   /// </summary>
   public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000.0);

   /// <summary>
   /// teragram, defined as: gigagram × 1000.0
   /// </summary>
   public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000.0);

   /// <summary>
   /// petagram, defined as: teragram × 1000.0
   /// </summary>
   public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000.0);

   /// <summary>
   /// exagram, defined as: petagram × 1000.0
   /// </summary>
   public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000.0);

   /// <summary>
   /// zettagram, defined as: exagram × 1000.0
   /// </summary>
   public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000.0);

   /// <summary>
   /// yottagram, defined as: zettagram × 1000.0
   /// </summary>
   public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000.0);

   /// <summary>
   /// ronnagram, defined as: yottagram × 1000.0
   /// </summary>
   public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000.0);

   /// <summary>
   /// quettagram, defined as: ronnagram × 1000.0
   /// </summary>
   public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000.0);

   /// <summary>
   /// metric ton, a synonym for megagram
   /// </summary>
   public static readonly Mass MetricTon = new ("metric ton", "mt", Megagram);
}
