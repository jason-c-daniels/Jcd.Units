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
/// International System of Units for measuring Catalytic Activity.
/// </summary>
public class CatalyticActivities : UnitOfMeasureEnumeration<CatalyticActivities, CatalyticActivity>
{
   /// <summary>
   /// katal, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly CatalyticActivity Katal = new ("katal", "kat");

   /// <summary>
   /// decikatal, defined as: katal × 1.0/10.0
   /// </summary>
   public static readonly CatalyticActivity Decikatal = new ("decikatal", "dkat", Katal, 1.0 / 10.0);

   /// <summary>
   /// centikatal, defined as: decikatal × 1.0/10.0
   /// </summary>
   public static readonly CatalyticActivity Centikatal = new ("centikatal", "ckat", Decikatal, 1.0 / 10.0);

   /// <summary>
   /// millikatal, defined as: centikatal × 1.0/10.0
   /// </summary>
   public static readonly CatalyticActivity Millikatal = new ("millikatal", "mkat", Centikatal, 1.0 / 10.0);

   /// <summary>
   /// microkatal, defined as: millikatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Microkatal = new ("microkatal", "μkat", Millikatal, 1.0 / 1000.0);

   /// <summary>
   /// nanokatal, defined as: microkatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Nanokatal = new ("nanokatal", "nkat", Microkatal, 1.0 / 1000.0);

   /// <summary>
   /// picokatal, defined as: nanokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Picokatal = new ("picokatal", "pkat", Nanokatal, 1.0 / 1000.0);

   /// <summary>
   /// femtokatal, defined as: picokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Femtokatal = new ("femtokatal", "fkat", Picokatal, 1.0 / 1000.0);

   /// <summary>
   /// attokatal, defined as: femtokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Attokatal = new ("attokatal", "akat", Femtokatal, 1.0 / 1000.0);

   /// <summary>
   /// zeptokatal, defined as: attokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Zeptokatal = new ("zeptokatal", "zkat", Attokatal, 1.0 / 1000.0);

   /// <summary>
   /// yoctokatal, defined as: zeptokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Yoctokatal = new ("yoctokatal", "ykat", Zeptokatal, 1.0 / 1000.0);

   /// <summary>
   /// rontokatal, defined as: yoctokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Rontokatal = new ("rontokatal", "rkat", Yoctokatal, 1.0 / 1000.0);

   /// <summary>
   /// quectokatal, defined as: rontokatal × 1.0/1000.0
   /// </summary>
   public static readonly CatalyticActivity Quectokatal = new ("quectokatal", "qkat", Rontokatal, 1.0 / 1000.0);

   /// <summary>
   /// dekakatal, defined as: katal × 10.0
   /// </summary>
   public static readonly CatalyticActivity Dekakatal = new ("dekakatal", "dakat", Katal, 10.0);

   /// <summary>
   /// hectokatal, defined as: dekakatal × 10.0
   /// </summary>
   public static readonly CatalyticActivity Hectokatal = new ("hectokatal", "hkat", Dekakatal, 10.0);

   /// <summary>
   /// kilokatal, defined as: hectokatal × 10.0
   /// </summary>
   public static readonly CatalyticActivity Kilokatal = new ("kilokatal", "kkat", Hectokatal, 10.0);

   /// <summary>
   /// megakatal, defined as: kilokatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Megakatal = new ("megakatal", "Mkat", Kilokatal, 1000.0);

   /// <summary>
   /// gigakatal, defined as: megakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Gigakatal = new ("gigakatal", "Gkat", Megakatal, 1000.0);

   /// <summary>
   /// terakatal, defined as: gigakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Terakatal = new ("terakatal", "Tkat", Gigakatal, 1000.0);

   /// <summary>
   /// petakatal, defined as: terakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Petakatal = new ("petakatal", "Pkat", Terakatal, 1000.0);

   /// <summary>
   /// exakatal, defined as: petakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Exakatal = new ("exakatal", "Ekat", Petakatal, 1000.0);

   /// <summary>
   /// zettakatal, defined as: exakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Zettakatal = new ("zettakatal", "Zkat", Exakatal, 1000.0);

   /// <summary>
   /// yottakatal, defined as: zettakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Yottakatal = new ("yottakatal", "Ykat", Zettakatal, 1000.0);

   /// <summary>
   /// ronnakatal, defined as: yottakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Ronnakatal = new ("ronnakatal", "Rkat", Yottakatal, 1000.0);

   /// <summary>
   /// quettakatal, defined as: ronnakatal × 1000.0
   /// </summary>
   public static readonly CatalyticActivity Quettakatal = new ("quettakatal", "Qkat", Ronnakatal, 1000.0);
}
