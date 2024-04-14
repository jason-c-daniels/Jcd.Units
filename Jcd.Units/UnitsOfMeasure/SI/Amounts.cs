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
   /// mole defined such that:  count = mol × 6.02214076E+23.
   /// </summary>
   public static readonly Amount Mole = new("mole", "mol", UnitsOfMeasure.Amounts.Count, 6.02214076E+23, system: "SI");
   
   /// <summary>
   /// decimole defined such that: mole = dmol × 1.0/10.0.
   /// </summary>
   public static readonly Amount Decimole = new("decimole", "dmol", Mole, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centimole defined such that: decimole = cmol × 1.0/10.0.
   /// </summary>
   public static readonly Amount Centimole = new("centimole", "cmol", Decimole, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millimole defined such that: centimole = mmol × 1.0/10.0.
   /// </summary>
   public static readonly Amount Millimole = new("millimole", "mmol", Centimole, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// micromole defined such that: millimole = μmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Micromole = new("micromole", "μmol", Millimole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanomole defined such that: micromole = nmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Nanomole = new("nanomole", "nmol", Micromole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picomole defined such that: nanomole = pmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Picomole = new("picomole", "pmol", Nanomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtomole defined such that: picomole = fmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Femtomole = new("femtomole", "fmol", Picomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attomole defined such that: femtomole = amol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Attomole = new("attomole", "amol", Femtomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptomole defined such that: attomole = zmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Zeptomole = new("zeptomole", "zmol", Attomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctomole defined such that: zeptomole = ymol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Yoctomole = new("yoctomole", "ymol", Zeptomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontomole defined such that: yoctomole = rmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Rontomole = new("rontomole", "rmol", Yoctomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectomole defined such that: rontomole = qmol × 1.0/1000.0.
   /// </summary>
   public static readonly Amount Quectomole = new("quectomole", "qmol", Rontomole, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekamole defined such that: mole = damol × 10.0.
   /// </summary>
   public static readonly Amount Dekamole = new("dekamole", "damol", Mole, 10.0, system: "SI");
   
   /// <summary>
   /// hectomole defined such that: dekamole = hmol × 10.0.
   /// </summary>
   public static readonly Amount Hectomole = new("hectomole", "hmol", Dekamole, 10.0, system: "SI");
   
   /// <summary>
   /// kilomole defined such that: hectomole = kmol × 10.0.
   /// </summary>
   public static readonly Amount Kilomole = new("kilomole", "kmol", Hectomole, 10.0, system: "SI");
   
   /// <summary>
   /// megamole defined such that: kilomole = Mmol × 1000.0.
   /// </summary>
   public static readonly Amount Megamole = new("megamole", "Mmol", Kilomole, 1000.0, system: "SI");
   
   /// <summary>
   /// gigamole defined such that: megamole = Gmol × 1000.0.
   /// </summary>
   public static readonly Amount Gigamole = new("gigamole", "Gmol", Megamole, 1000.0, system: "SI");
   
   /// <summary>
   /// teramole defined such that: gigamole = Tmol × 1000.0.
   /// </summary>
   public static readonly Amount Teramole = new("teramole", "Tmol", Gigamole, 1000.0, system: "SI");
   
   /// <summary>
   /// petamole defined such that: teramole = Pmol × 1000.0.
   /// </summary>
   public static readonly Amount Petamole = new("petamole", "Pmol", Teramole, 1000.0, system: "SI");
   
   /// <summary>
   /// examole defined such that: petamole = Emol × 1000.0.
   /// </summary>
   public static readonly Amount Examole = new("examole", "Emol", Petamole, 1000.0, system: "SI");
   
   /// <summary>
   /// zettamole defined such that: examole = Zmol × 1000.0.
   /// </summary>
   public static readonly Amount Zettamole = new("zettamole", "Zmol", Examole, 1000.0, system: "SI");
   
   /// <summary>
   /// yottamole defined such that: zettamole = Ymol × 1000.0.
   /// </summary>
   public static readonly Amount Yottamole = new("yottamole", "Ymol", Zettamole, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnamole defined such that: yottamole = Rmol × 1000.0.
   /// </summary>
   public static readonly Amount Ronnamole = new("ronnamole", "Rmol", Yottamole, 1000.0, system: "SI");
   
   /// <summary>
   /// quettamole defined such that: ronnamole = Qmol × 1000.0.
   /// </summary>
   public static readonly Amount Quettamole = new("quettamole", "Qmol", Ronnamole, 1000.0, system: "SI");
}