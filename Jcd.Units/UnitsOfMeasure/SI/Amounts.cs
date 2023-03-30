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
   /// mole, defined as:  count × 6.02214076E+23
   /// </summary>
   public static readonly Amount Mole = new ("mole", "mol", UnitsOfMeasure.Amounts.Count, 6.02214076E+23);

   /// <summary>
   /// decimole, defined as: mole × 1.0/10.0
   /// </summary>
   public static readonly Amount Decimole = new ("decimole", "dmol", Mole, 1.0 / 10.0);

   /// <summary>
   /// centimole, defined as: decimole × 1.0/10.0
   /// </summary>
   public static readonly Amount Centimole = new ("centimole", "cmol", Decimole, 1.0 / 10.0);

   /// <summary>
   /// millimole, defined as: centimole × 1.0/10.0
   /// </summary>
   public static readonly Amount Millimole = new ("millimole", "mmol", Centimole, 1.0 / 10.0);

   /// <summary>
   /// micromole, defined as: millimole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Micromole = new ("micromole", "μmol", Millimole, 1.0 / 1000.0);

   /// <summary>
   /// nanomole, defined as: micromole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Nanomole = new ("nanomole", "nmol", Micromole, 1.0 / 1000.0);

   /// <summary>
   /// picomole, defined as: nanomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Picomole = new ("picomole", "pmol", Nanomole, 1.0 / 1000.0);

   /// <summary>
   /// femtomole, defined as: picomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Femtomole = new ("femtomole", "fmol", Picomole, 1.0 / 1000.0);

   /// <summary>
   /// attomole, defined as: femtomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Attomole = new ("attomole", "amol", Femtomole, 1.0 / 1000.0);

   /// <summary>
   /// zeptomole, defined as: attomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Zeptomole = new ("zeptomole", "zmol", Attomole, 1.0 / 1000.0);

   /// <summary>
   /// yoctomole, defined as: zeptomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Yoctomole = new ("yoctomole", "ymol", Zeptomole, 1.0 / 1000.0);

   /// <summary>
   /// rontomole, defined as: yoctomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Rontomole = new ("rontomole", "rmol", Yoctomole, 1.0 / 1000.0);

   /// <summary>
   /// quectomole, defined as: rontomole × 1.0/1000.0
   /// </summary>
   public static readonly Amount Quectomole = new ("quectomole", "qmol", Rontomole, 1.0 / 1000.0);

   /// <summary>
   /// dekamole, defined as: mole × 10.0
   /// </summary>
   public static readonly Amount Dekamole = new ("dekamole", "damol", Mole, 10.0);

   /// <summary>
   /// hectomole, defined as: dekamole × 10.0
   /// </summary>
   public static readonly Amount Hectomole = new ("hectomole", "hmol", Dekamole, 10.0);

   /// <summary>
   /// kilomole, defined as: hectomole × 10.0
   /// </summary>
   public static readonly Amount Kilomole = new ("kilomole", "kmol", Hectomole, 10.0);

   /// <summary>
   /// megamole, defined as: kilomole × 1000.0
   /// </summary>
   public static readonly Amount Megamole = new ("megamole", "Mmol", Kilomole, 1000.0);

   /// <summary>
   /// gigamole, defined as: megamole × 1000.0
   /// </summary>
   public static readonly Amount Gigamole = new ("gigamole", "Gmol", Megamole, 1000.0);

   /// <summary>
   /// teramole, defined as: gigamole × 1000.0
   /// </summary>
   public static readonly Amount Teramole = new ("teramole", "Tmol", Gigamole, 1000.0);

   /// <summary>
   /// petamole, defined as: teramole × 1000.0
   /// </summary>
   public static readonly Amount Petamole = new ("petamole", "Pmol", Teramole, 1000.0);

   /// <summary>
   /// examole, defined as: petamole × 1000.0
   /// </summary>
   public static readonly Amount Examole = new ("examole", "Emol", Petamole, 1000.0);

   /// <summary>
   /// zettamole, defined as: examole × 1000.0
   /// </summary>
   public static readonly Amount Zettamole = new ("zettamole", "Zmol", Examole, 1000.0);

   /// <summary>
   /// yottamole, defined as: zettamole × 1000.0
   /// </summary>
   public static readonly Amount Yottamole = new ("yottamole", "Ymol", Zettamole, 1000.0);

   /// <summary>
   /// ronnamole, defined as: yottamole × 1000.0
   /// </summary>
   public static readonly Amount Ronnamole = new ("ronnamole", "Rmol", Yottamole, 1000.0);

   /// <summary>
   /// quettamole, defined as: ronnamole × 1000.0
   /// </summary>
   public static readonly Amount Quettamole = new ("quettamole", "Qmol", Ronnamole, 1000.0);
}
