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
   /// A(n) katal.
   /// </summary>
   public static readonly CatalyticActivity Katal = new ("katal", "kat");

   /// <summary>
   /// A(n) decikatal. Defined as: (1.0/10.0) × katal + (0).
   /// </summary>
   public static readonly CatalyticActivity Decikatal = new ("decikatal", "dkat", Katal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centikatal. Defined as: (1.0/10.0) × decikatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Centikatal = new ("centikatal", "ckat", Decikatal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millikatal. Defined as: (1.0/10.0) × centikatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Millikatal = new ("millikatal", "mkat", Centikatal, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microkatal. Defined as: (1.0/1000.0) × millikatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Microkatal = new ("microkatal", "μkat", Millikatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanokatal. Defined as: (1.0/1000.0) × microkatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Nanokatal = new ("nanokatal", "nkat", Microkatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picokatal. Defined as: (1.0/1000.0) × nanokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Picokatal = new ("picokatal", "pkat", Nanokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtokatal. Defined as: (1.0/1000.0) × picokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Femtokatal = new ("femtokatal", "fkat", Picokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attokatal. Defined as: (1.0/1000.0) × femtokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Attokatal = new ("attokatal", "akat", Femtokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptokatal. Defined as: (1.0/1000.0) × attokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Zeptokatal = new ("zeptokatal", "zkat", Attokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctokatal. Defined as: (1.0/1000.0) × zeptokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Yoctokatal = new ("yoctokatal", "ykat", Zeptokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontokatal. Defined as: (1.0/1000.0) × yoctokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Rontokatal = new ("rontokatal", "rkat", Yoctokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectokatal. Defined as: (1.0/1000.0) × rontokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Quectokatal = new ("quectokatal", "qkat", Rontokatal, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekakatal. Defined as: (10.0) × katal + (0).
   /// </summary>
   public static readonly CatalyticActivity Dekakatal = new ("dekakatal", "dakat", Katal, 10.0, 0);

   /// <summary>
   /// A(n) hectokatal. Defined as: (10.0) × dekakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Hectokatal = new ("hectokatal", "hkat", Dekakatal, 10.0, 0);

   /// <summary>
   /// A(n) kilokatal. Defined as: (10.0) × hectokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Kilokatal = new ("kilokatal", "kkat", Hectokatal, 10.0, 0);

   /// <summary>
   /// A(n) megakatal. Defined as: (1000.0) × kilokatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Megakatal = new ("megakatal", "Mkat", Kilokatal, 1000.0, 0);

   /// <summary>
   /// A(n) gigakatal. Defined as: (1000.0) × megakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Gigakatal = new ("gigakatal", "Gkat", Megakatal, 1000.0, 0);

   /// <summary>
   /// A(n) terakatal. Defined as: (1000.0) × gigakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Terakatal = new ("terakatal", "Tkat", Gigakatal, 1000.0, 0);

   /// <summary>
   /// A(n) petakatal. Defined as: (1000.0) × terakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Petakatal = new ("petakatal", "Pkat", Terakatal, 1000.0, 0);

   /// <summary>
   /// A(n) exakatal. Defined as: (1000.0) × petakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Exakatal = new ("exakatal", "Ekat", Petakatal, 1000.0, 0);

   /// <summary>
   /// A(n) zettakatal. Defined as: (1000.0) × exakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Zettakatal = new ("zettakatal", "Zkat", Exakatal, 1000.0, 0);

   /// <summary>
   /// A(n) yottakatal. Defined as: (1000.0) × zettakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Yottakatal = new ("yottakatal", "Ykat", Zettakatal, 1000.0, 0);

   /// <summary>
   /// A(n) ronnakatal. Defined as: (1000.0) × yottakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Ronnakatal = new ("ronnakatal", "Rkat", Yottakatal, 1000.0, 0);

   /// <summary>
   /// A(n) quettakatal. Defined as: (1000.0) × ronnakatal + (0).
   /// </summary>
   public static readonly CatalyticActivity Quettakatal = new ("quettakatal", "Qkat", Ronnakatal, 1000.0, 0);
}
