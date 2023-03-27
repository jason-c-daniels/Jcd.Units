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
/// International System of Units for measuring Amount.
/// </summary>
public class Amounts : UnitOfMeasureEnumeration<Amounts, Amount>
{
   /// <summary>
   /// A(n) mole. Defined as: (6.02214076E+23) ×  count + (0).
   /// </summary>
   public static readonly Amount Mole = new ("mole", "mol", UnitsOfMeasure.Amounts.Count, 6.02214076E+23, 0);

   /// <summary>
   /// A(n) decimole. Defined as: (1.0/10.0) × mole + (0).
   /// </summary>
   public static readonly Amount Decimole = new ("decimole", "dmol", Mole, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centimole. Defined as: (1.0/10.0) × decimole + (0).
   /// </summary>
   public static readonly Amount Centimole = new ("centimole", "cmol", Decimole, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millimole. Defined as: (1.0/10.0) × centimole + (0).
   /// </summary>
   public static readonly Amount Millimole = new ("millimole", "mmol", Centimole, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) micromole. Defined as: (1.0/1000.0) × millimole + (0).
   /// </summary>
   public static readonly Amount Micromole = new ("micromole", "μmol", Millimole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanomole. Defined as: (1.0/1000.0) × micromole + (0).
   /// </summary>
   public static readonly Amount Nanomole = new ("nanomole", "nmol", Micromole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picomole. Defined as: (1.0/1000.0) × nanomole + (0).
   /// </summary>
   public static readonly Amount Picomole = new ("picomole", "pmol", Nanomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtomole. Defined as: (1.0/1000.0) × picomole + (0).
   /// </summary>
   public static readonly Amount Femtomole = new ("femtomole", "fmol", Picomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attomole. Defined as: (1.0/1000.0) × femtomole + (0).
   /// </summary>
   public static readonly Amount Attomole = new ("attomole", "amol", Femtomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptomole. Defined as: (1.0/1000.0) × attomole + (0).
   /// </summary>
   public static readonly Amount Zeptomole = new ("zeptomole", "zmol", Attomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctomole. Defined as: (1.0/1000.0) × zeptomole + (0).
   /// </summary>
   public static readonly Amount Yoctomole = new ("yoctomole", "ymol", Zeptomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontomole. Defined as: (1.0/1000.0) × yoctomole + (0).
   /// </summary>
   public static readonly Amount Rontomole = new ("rontomole", "rmol", Yoctomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectomole. Defined as: (1.0/1000.0) × rontomole + (0).
   /// </summary>
   public static readonly Amount Quectomole = new ("quectomole", "qmol", Rontomole, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekamole. Defined as: (10.0) × mole + (0).
   /// </summary>
   public static readonly Amount Dekamole = new ("dekamole", "damol", Mole, 10.0, 0);

   /// <summary>
   /// A(n) hectomole. Defined as: (10.0) × dekamole + (0).
   /// </summary>
   public static readonly Amount Hectomole = new ("hectomole", "hmol", Dekamole, 10.0, 0);

   /// <summary>
   /// A(n) kilomole. Defined as: (10.0) × hectomole + (0).
   /// </summary>
   public static readonly Amount Kilomole = new ("kilomole", "kmol", Hectomole, 10.0, 0);

   /// <summary>
   /// A(n) megamole. Defined as: (1000.0) × kilomole + (0).
   /// </summary>
   public static readonly Amount Megamole = new ("megamole", "Mmol", Kilomole, 1000.0, 0);

   /// <summary>
   /// A(n) gigamole. Defined as: (1000.0) × megamole + (0).
   /// </summary>
   public static readonly Amount Gigamole = new ("gigamole", "Gmol", Megamole, 1000.0, 0);

   /// <summary>
   /// A(n) teramole. Defined as: (1000.0) × gigamole + (0).
   /// </summary>
   public static readonly Amount Teramole = new ("teramole", "Tmol", Gigamole, 1000.0, 0);

   /// <summary>
   /// A(n) petamole. Defined as: (1000.0) × teramole + (0).
   /// </summary>
   public static readonly Amount Petamole = new ("petamole", "Pmol", Teramole, 1000.0, 0);

   /// <summary>
   /// A(n) examole. Defined as: (1000.0) × petamole + (0).
   /// </summary>
   public static readonly Amount Examole = new ("examole", "Emol", Petamole, 1000.0, 0);

   /// <summary>
   /// A(n) zettamole. Defined as: (1000.0) × examole + (0).
   /// </summary>
   public static readonly Amount Zettamole = new ("zettamole", "Zmol", Examole, 1000.0, 0);

   /// <summary>
   /// A(n) yottamole. Defined as: (1000.0) × zettamole + (0).
   /// </summary>
   public static readonly Amount Yottamole = new ("yottamole", "Ymol", Zettamole, 1000.0, 0);

   /// <summary>
   /// A(n) ronnamole. Defined as: (1000.0) × yottamole + (0).
   /// </summary>
   public static readonly Amount Ronnamole = new ("ronnamole", "Rmol", Yottamole, 1000.0, 0);

   /// <summary>
   /// A(n) quettamole. Defined as: (1000.0) × ronnamole + (0).
   /// </summary>
   public static readonly Amount Quettamole = new ("quettamole", "Qmol", Ronnamole, 1000.0, 0);
}
