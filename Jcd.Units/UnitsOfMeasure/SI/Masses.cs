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
   public static readonly Mass Kilogram = new ("kilogram", "kg", system: "SI");

   /// <summary>
   /// hectogram defined such that: kilogram = hg × 1.0/10.0.
   /// </summary>
   public static readonly Mass Hectogram = new ("hectogram", "hg", Kilogram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// dekagram defined such that: hectogram = dag × 1.0/10.0.
   /// </summary>
   public static readonly Mass Dekagram = new ("dekagram", "dag", Hectogram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// gram defined such that: dekagram = g × 1.0/10.0.
   /// </summary>
   public static readonly Mass Gram = new ("gram", "g", Dekagram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// decigram defined such that: gram = dg × 1.0/10.0.
   /// </summary>
   public static readonly Mass Decigram = new ("decigram", "dg", Gram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centigram defined such that: decigram = cg × 1.0/10.0.
   /// </summary>
   public static readonly Mass Centigram = new ("centigram", "cg", Decigram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// milligram defined such that: centigram = mg × 1.0/10.0.
   /// </summary>
   public static readonly Mass Milligram = new ("milligram", "mg", Centigram, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microgram defined such that: milligram = μg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Microgram = new ("microgram", "μg", Milligram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanogram defined such that: microgram = ng × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Nanogram = new ("nanogram", "ng", Microgram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picogram defined such that: nanogram = pg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Picogram = new ("picogram", "pg", Nanogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtogram defined such that: picogram = fg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Femtogram = new ("femtogram", "fg", Picogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attogram defined such that: femtogram = ag × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Attogram = new ("attogram", "ag", Femtogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptogram defined such that: attogram = zg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Zeptogram = new ("zeptogram", "zg", Attogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctogram defined such that: zeptogram = yg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Yoctogram = new ("yoctogram", "yg", Zeptogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontogram defined such that: yoctogram = rg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Rontogram = new ("rontogram", "rg", Yoctogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectogram defined such that: rontogram = qg × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Quectogram = new ("quectogram", "qg", Rontogram, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// megagram defined such that: kilogram = Mg × 1000.0.
   /// </summary>
   public static readonly Mass Megagram = new ("megagram", "Mg", Kilogram, 1000.0, system: "SI");

   /// <summary>
   /// gigagram defined such that: megagram = Gg × 1000.0.
   /// </summary>
   public static readonly Mass Gigagram = new ("gigagram", "Gg", Megagram, 1000.0, system: "SI");

   /// <summary>
   /// teragram defined such that: gigagram = Tg × 1000.0.
   /// </summary>
   public static readonly Mass Teragram = new ("teragram", "Tg", Gigagram, 1000.0, system: "SI");

   /// <summary>
   /// petagram defined such that: teragram = Pg × 1000.0.
   /// </summary>
   public static readonly Mass Petagram = new ("petagram", "Pg", Teragram, 1000.0, system: "SI");

   /// <summary>
   /// exagram defined such that: petagram = Eg × 1000.0.
   /// </summary>
   public static readonly Mass Exagram = new ("exagram", "Eg", Petagram, 1000.0, system: "SI");

   /// <summary>
   /// zettagram defined such that: exagram = Zg × 1000.0.
   /// </summary>
   public static readonly Mass Zettagram = new ("zettagram", "Zg", Exagram, 1000.0, system: "SI");

   /// <summary>
   /// yottagram defined such that: zettagram = Yg × 1000.0.
   /// </summary>
   public static readonly Mass Yottagram = new ("yottagram", "Yg", Zettagram, 1000.0, system: "SI");

   /// <summary>
   /// ronnagram defined such that: yottagram = Rg × 1000.0.
   /// </summary>
   public static readonly Mass Ronnagram = new ("ronnagram", "Rg", Yottagram, 1000.0, system: "SI");

   /// <summary>
   /// quettagram defined such that: ronnagram = Qg × 1000.0.
   /// </summary>
   public static readonly Mass Quettagram = new ("quettagram", "Qg", Ronnagram, 1000.0, system: "SI");

   /// <summary>
   /// metric ton is a synonym for megagram
   /// </summary>
   public static readonly Mass MetricTon = new ("metric ton", "Mt", Megagram, system: "SI");

   /// <summary>
   /// tonne is a synonym for megagram
   /// </summary>
   public static readonly Mass Tonne = new ("tonne", "t", Megagram, system: "SI");

   /// <summary>
   /// decitonne defined such that: tonne = dt × 1.0/10.0.
   /// </summary>
   public static readonly Mass Decitonne = new ("decitonne", "dt", Tonne, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// centitonne defined such that: decitonne = ct × 1.0/10.0.
   /// </summary>
   public static readonly Mass Centitonne = new ("centitonne", "ct", Decitonne, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// millitonne defined such that: centitonne = mt × 1.0/10.0.
   /// </summary>
   public static readonly Mass Millitonne = new ("millitonne", "mt", Centitonne, 1.0 / 10.0, system: "SI");

   /// <summary>
   /// microtonne defined such that: millitonne = μt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Microtonne = new ("microtonne", "μt", Millitonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// nanotonne defined such that: microtonne = nt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Nanotonne = new ("nanotonne", "nt", Microtonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// picotonne defined such that: nanotonne = pt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Picotonne = new ("picotonne", "pt", Nanotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// femtotonne defined such that: picotonne = ft × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Femtotonne = new ("femtotonne", "ft", Picotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// attotonne defined such that: femtotonne = at × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Attotonne = new ("attotonne", "at", Femtotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// zeptotonne defined such that: attotonne = zt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Zeptotonne = new ("zeptotonne", "zt", Attotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// yoctotonne defined such that: zeptotonne = yt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Yoctotonne = new ("yoctotonne", "yt", Zeptotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// rontotonne defined such that: yoctotonne = rt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Rontotonne = new ("rontotonne", "rt", Yoctotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// quectotonne defined such that: rontotonne = qt × 1.0/1000.0.
   /// </summary>
   public static readonly Mass Quectotonne = new ("quectotonne", "qt", Rontotonne, 1.0 / 1000.0, system: "SI");

   /// <summary>
   /// dekatonne defined such that: tonne = dat × 10.0.
   /// </summary>
   public static readonly Mass Dekatonne = new ("dekatonne", "dat", Tonne, 10.0, system: "SI");

   /// <summary>
   /// hectotonne defined such that: dekatonne = ht × 10.0.
   /// </summary>
   public static readonly Mass Hectotonne = new ("hectotonne", "ht", Dekatonne, 10.0, system: "SI");

   /// <summary>
   /// kilotonne defined such that: hectotonne = kt × 10.0.
   /// </summary>
   public static readonly Mass Kilotonne = new ("kilotonne", "kt", Hectotonne, 10.0, system: "SI");

   /// <summary>
   /// megatonne defined such that: kilotonne = Mt × 1000.0.
   /// </summary>
   public static readonly Mass Megatonne = new ("megatonne", "Mt", Kilotonne, 1000.0, system: "SI");

   /// <summary>
   /// gigatonne defined such that: megatonne = Gt × 1000.0.
   /// </summary>
   public static readonly Mass Gigatonne = new ("gigatonne", "Gt", Megatonne, 1000.0, system: "SI");

   /// <summary>
   /// teratonne defined such that: gigatonne = Tt × 1000.0.
   /// </summary>
   public static readonly Mass Teratonne = new ("teratonne", "Tt", Gigatonne, 1000.0, system: "SI");

   /// <summary>
   /// petatonne defined such that: teratonne = Pt × 1000.0.
   /// </summary>
   public static readonly Mass Petatonne = new ("petatonne", "Pt", Teratonne, 1000.0, system: "SI");

   /// <summary>
   /// exatonne defined such that: petatonne = Et × 1000.0.
   /// </summary>
   public static readonly Mass Exatonne = new ("exatonne", "Et", Petatonne, 1000.0, system: "SI");

   /// <summary>
   /// zettatonne defined such that: exatonne = Zt × 1000.0.
   /// </summary>
   public static readonly Mass Zettatonne = new ("zettatonne", "Zt", Exatonne, 1000.0, system: "SI");

   /// <summary>
   /// yottatonne defined such that: zettatonne = Yt × 1000.0.
   /// </summary>
   public static readonly Mass Yottatonne = new ("yottatonne", "Yt", Zettatonne, 1000.0, system: "SI");

   /// <summary>
   /// ronnatonne defined such that: yottatonne = Rt × 1000.0.
   /// </summary>
   public static readonly Mass Ronnatonne = new ("ronnatonne", "Rt", Yottatonne, 1000.0, system: "SI");

   /// <summary>
   /// quettatonne defined such that: ronnatonne = Qt × 1000.0.
   /// </summary>
   public static readonly Mass Quettatonne = new ("quettatonne", "Qt", Ronnatonne, 1000.0, system: "SI");
}
