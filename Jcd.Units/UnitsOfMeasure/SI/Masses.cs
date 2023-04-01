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

   /// <summary>
   /// tonne, a synonym for megagram
   /// </summary>
   public static readonly Mass Tonne = new ("tonne", "t", Megagram);

   /// <summary>
   /// decitonne, defined as: tonne × 1.0/10.0
   /// </summary>
   public static readonly Mass Decitonne = new ("decitonne", "dt", Tonne, 1.0 / 10.0);

   /// <summary>
   /// centitonne, defined as: decitonne × 1.0/10.0
   /// </summary>
   public static readonly Mass Centitonne = new ("centitonne", "ct", Decitonne, 1.0 / 10.0);

   /// <summary>
   /// millitonne, defined as: centitonne × 1.0/10.0
   /// </summary>
   public static readonly Mass Millitonne = new ("millitonne", "mt", Centitonne, 1.0 / 10.0);

   /// <summary>
   /// microtonne, defined as: millitonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Microtonne = new ("microtonne", "μt", Millitonne, 1.0 / 1000.0);

   /// <summary>
   /// nanotonne, defined as: microtonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Nanotonne = new ("nanotonne", "nt", Microtonne, 1.0 / 1000.0);

   /// <summary>
   /// picotonne, defined as: nanotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Picotonne = new ("picotonne", "pt", Nanotonne, 1.0 / 1000.0);

   /// <summary>
   /// femtotonne, defined as: picotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Femtotonne = new ("femtotonne", "ft", Picotonne, 1.0 / 1000.0);

   /// <summary>
   /// attotonne, defined as: femtotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Attotonne = new ("attotonne", "at", Femtotonne, 1.0 / 1000.0);

   /// <summary>
   /// zeptotonne, defined as: attotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Zeptotonne = new ("zeptotonne", "zt", Attotonne, 1.0 / 1000.0);

   /// <summary>
   /// yoctotonne, defined as: zeptotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Yoctotonne = new ("yoctotonne", "yt", Zeptotonne, 1.0 / 1000.0);

   /// <summary>
   /// rontotonne, defined as: yoctotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Rontotonne = new ("rontotonne", "rt", Yoctotonne, 1.0 / 1000.0);

   /// <summary>
   /// quectotonne, defined as: rontotonne × 1.0/1000.0
   /// </summary>
   public static readonly Mass Quectotonne = new ("quectotonne", "qt", Rontotonne, 1.0 / 1000.0);

   /// <summary>
   /// dekatonne, defined as: tonne × 10.0
   /// </summary>
   public static readonly Mass Dekatonne = new ("dekatonne", "dat", Tonne, 10.0);

   /// <summary>
   /// hectotonne, defined as: dekatonne × 10.0
   /// </summary>
   public static readonly Mass Hectotonne = new ("hectotonne", "ht", Dekatonne, 10.0);

   /// <summary>
   /// kilotonne, defined as: hectotonne × 10.0
   /// </summary>
   public static readonly Mass Kilotonne = new ("kilotonne", "kt", Hectotonne, 10.0);

   /// <summary>
   /// megatonne, defined as: kilotonne × 1000.0
   /// </summary>
   public static readonly Mass Megatonne = new ("megatonne", "Mt", Kilotonne, 1000.0);

   /// <summary>
   /// gigatonne, defined as: megatonne × 1000.0
   /// </summary>
   public static readonly Mass Gigatonne = new ("gigatonne", "Gt", Megatonne, 1000.0);

   /// <summary>
   /// teratonne, defined as: gigatonne × 1000.0
   /// </summary>
   public static readonly Mass Teratonne = new ("teratonne", "Tt", Gigatonne, 1000.0);

   /// <summary>
   /// petatonne, defined as: teratonne × 1000.0
   /// </summary>
   public static readonly Mass Petatonne = new ("petatonne", "Pt", Teratonne, 1000.0);

   /// <summary>
   /// exatonne, defined as: petatonne × 1000.0
   /// </summary>
   public static readonly Mass Exatonne = new ("exatonne", "Et", Petatonne, 1000.0);

   /// <summary>
   /// zettatonne, defined as: exatonne × 1000.0
   /// </summary>
   public static readonly Mass Zettatonne = new ("zettatonne", "Zt", Exatonne, 1000.0);

   /// <summary>
   /// yottatonne, defined as: zettatonne × 1000.0
   /// </summary>
   public static readonly Mass Yottatonne = new ("yottatonne", "Yt", Zettatonne, 1000.0);

   /// <summary>
   /// ronnatonne, defined as: yottatonne × 1000.0
   /// </summary>
   public static readonly Mass Ronnatonne = new ("ronnatonne", "Rt", Yottatonne, 1000.0);

   /// <summary>
   /// quettatonne, defined as: ronnatonne × 1000.0
   /// </summary>
   public static readonly Mass Quettatonne = new ("quettatonne", "Qt", Ronnatonne, 1000.0);
}
