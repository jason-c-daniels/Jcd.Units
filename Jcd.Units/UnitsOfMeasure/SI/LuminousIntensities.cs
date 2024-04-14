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
/// International System of Units for measuring Luminous Intensity.
/// </summary>
public class LuminousIntensities : UnitOfMeasureEnumeration<LuminousIntensities, LuminousIntensity>
{
   /// <summary>
   /// candela, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly LuminousIntensity Candela = new("candela", "cd", system: "SI");
   
   /// <summary>
   /// decicandela defined such that: candela = dcd × 1.0/10.0.
   /// </summary>
   public static readonly LuminousIntensity Decicandela = new("decicandela", "dcd", Candela, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// centicandela defined such that: decicandela = ccd × 1.0/10.0.
   /// </summary>
   public static readonly LuminousIntensity Centicandela = new("centicandela", "ccd", Decicandela, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// millicandela defined such that: centicandela = mcd × 1.0/10.0.
   /// </summary>
   public static readonly LuminousIntensity Millicandela = new("millicandela", "mcd", Centicandela, 1.0 / 10.0, system: "SI");
   
   /// <summary>
   /// microcandela defined such that: millicandela = μcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Microcandela = new("microcandela", "μcd", Millicandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// nanocandela defined such that: microcandela = ncd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Nanocandela = new("nanocandela", "ncd", Microcandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// picocandela defined such that: nanocandela = pcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Picocandela = new("picocandela", "pcd", Nanocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// femtocandela defined such that: picocandela = fcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Femtocandela = new("femtocandela", "fcd", Picocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// attocandela defined such that: femtocandela = acd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Attocandela = new("attocandela", "acd", Femtocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// zeptocandela defined such that: attocandela = zcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Zeptocandela = new("zeptocandela", "zcd", Attocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// yoctocandela defined such that: zeptocandela = ycd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Yoctocandela = new("yoctocandela", "ycd", Zeptocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// rontocandela defined such that: yoctocandela = rcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Rontocandela = new("rontocandela", "rcd", Yoctocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// quectocandela defined such that: rontocandela = qcd × 1.0/1000.0.
   /// </summary>
   public static readonly LuminousIntensity Quectocandela = new("quectocandela", "qcd", Rontocandela, 1.0 / 1000.0, system: "SI");
   
   /// <summary>
   /// dekacandela defined such that: candela = dacd × 10.0.
   /// </summary>
   public static readonly LuminousIntensity Dekacandela = new("dekacandela", "dacd", Candela, 10.0, system: "SI");
   
   /// <summary>
   /// hectocandela defined such that: dekacandela = hcd × 10.0.
   /// </summary>
   public static readonly LuminousIntensity Hectocandela = new("hectocandela", "hcd", Dekacandela, 10.0, system: "SI");
   
   /// <summary>
   /// kilocandela defined such that: hectocandela = kcd × 10.0.
   /// </summary>
   public static readonly LuminousIntensity Kilocandela = new("kilocandela", "kcd", Hectocandela, 10.0, system: "SI");
   
   /// <summary>
   /// megacandela defined such that: kilocandela = Mcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Megacandela = new("megacandela", "Mcd", Kilocandela, 1000.0, system: "SI");
   
   /// <summary>
   /// gigacandela defined such that: megacandela = Gcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Gigacandela = new("gigacandela", "Gcd", Megacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// teracandela defined such that: gigacandela = Tcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Teracandela = new("teracandela", "Tcd", Gigacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// petacandela defined such that: teracandela = Pcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Petacandela = new("petacandela", "Pcd", Teracandela, 1000.0, system: "SI");
   
   /// <summary>
   /// exacandela defined such that: petacandela = Ecd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Exacandela = new("exacandela", "Ecd", Petacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// zettacandela defined such that: exacandela = Zcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Zettacandela = new("zettacandela", "Zcd", Exacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// yottacandela defined such that: zettacandela = Ycd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Yottacandela = new("yottacandela", "Ycd", Zettacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// ronnacandela defined such that: yottacandela = Rcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Ronnacandela = new("ronnacandela", "Rcd", Yottacandela, 1000.0, system: "SI");
   
   /// <summary>
   /// quettacandela defined such that: ronnacandela = Qcd × 1000.0.
   /// </summary>
   public static readonly LuminousIntensity Quettacandela = new("quettacandela", "Qcd", Ronnacandela, 1000.0, system: "SI");
}