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
public class LuminousIntensities : Enumeration<LuminousIntensities, LuminousIntensity>
{
   /// <summary>
   /// A(n) candela.
   /// </summary>
   public static readonly LuminousIntensity Candela = new ("candela", "cd");

   /// <summary>
   /// A(n) decicandela. Defined in terms of a(n) candela.
   /// </summary>
   public static readonly LuminousIntensity Decicandela = new ("decicandela", "dcd", Candela, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) centicandela. Defined in terms of a(n) decicandela.
   /// </summary>
   public static readonly LuminousIntensity Centicandela = new ("centicandela", "ccd", Decicandela, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) millicandela. Defined in terms of a(n) centicandela.
   /// </summary>
   public static readonly LuminousIntensity Millicandela = new ("millicandela", "mcd", Centicandela, 1.0 / 10.0, 0);

   /// <summary>
   /// A(n) microcandela. Defined in terms of a(n) millicandela.
   /// </summary>
   public static readonly LuminousIntensity Microcandela = new ("microcandela", "μcd", Millicandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) nanocandela. Defined in terms of a(n) microcandela.
   /// </summary>
   public static readonly LuminousIntensity Nanocandela = new ("nanocandela", "ncd", Microcandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) picocandela. Defined in terms of a(n) nanocandela.
   /// </summary>
   public static readonly LuminousIntensity Picocandela = new ("picocandela", "pcd", Nanocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) femtocandela. Defined in terms of a(n) picocandela.
   /// </summary>
   public static readonly LuminousIntensity Femtocandela = new ("femtocandela", "fcd", Picocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) attocandela. Defined in terms of a(n) femtocandela.
   /// </summary>
   public static readonly LuminousIntensity Attocandela = new ("attocandela", "acd", Femtocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) zeptocandela. Defined in terms of a(n) attocandela.
   /// </summary>
   public static readonly LuminousIntensity Zeptocandela = new ("zeptocandela", "zcd", Attocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) yoctocandela. Defined in terms of a(n) zeptocandela.
   /// </summary>
   public static readonly LuminousIntensity Yoctocandela = new ("yoctocandela", "ycd", Zeptocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) rontocandela. Defined in terms of a(n) yoctocandela.
   /// </summary>
   public static readonly LuminousIntensity Rontocandela = new ("rontocandela", "rcd", Yoctocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) quectocandela. Defined in terms of a(n) rontocandela.
   /// </summary>
   public static readonly LuminousIntensity Quectocandela = new ("quectocandela", "qcd", Rontocandela, 1.0 / 1000.0, 0);

   /// <summary>
   /// A(n) dekacandela. Defined in terms of a(n) candela.
   /// </summary>
   public static readonly LuminousIntensity Dekacandela = new ("dekacandela", "dacd", Candela, 10.0, 0);

   /// <summary>
   /// A(n) hectocandela. Defined in terms of a(n) dekacandela.
   /// </summary>
   public static readonly LuminousIntensity Hectocandela = new ("hectocandela", "hcd", Dekacandela, 10.0, 0);

   /// <summary>
   /// A(n) kilocandela. Defined in terms of a(n) hectocandela.
   /// </summary>
   public static readonly LuminousIntensity Kilocandela = new ("kilocandela", "kcd", Hectocandela, 10.0, 0);

   /// <summary>
   /// A(n) megacandela. Defined in terms of a(n) kilocandela.
   /// </summary>
   public static readonly LuminousIntensity Megacandela = new ("megacandela", "Mcd", Kilocandela, 1000.0, 0);

   /// <summary>
   /// A(n) gigacandela. Defined in terms of a(n) megacandela.
   /// </summary>
   public static readonly LuminousIntensity Gigacandela = new ("gigacandela", "Gcd", Megacandela, 1000.0, 0);

   /// <summary>
   /// A(n) teracandela. Defined in terms of a(n) gigacandela.
   /// </summary>
   public static readonly LuminousIntensity Teracandela = new ("teracandela", "Tcd", Gigacandela, 1000.0, 0);

   /// <summary>
   /// A(n) petacandela. Defined in terms of a(n) teracandela.
   /// </summary>
   public static readonly LuminousIntensity Petacandela = new ("petacandela", "Pcd", Teracandela, 1000.0, 0);

   /// <summary>
   /// A(n) exacandela. Defined in terms of a(n) petacandela.
   /// </summary>
   public static readonly LuminousIntensity Exacandela = new ("exacandela", "Ecd", Petacandela, 1000.0, 0);

   /// <summary>
   /// A(n) zettacandela. Defined in terms of a(n) exacandela.
   /// </summary>
   public static readonly LuminousIntensity Zettacandela = new ("zettacandela", "Zcd", Exacandela, 1000.0, 0);

   /// <summary>
   /// A(n) yottacandela. Defined in terms of a(n) zettacandela.
   /// </summary>
   public static readonly LuminousIntensity Yottacandela = new ("yottacandela", "Ycd", Zettacandela, 1000.0, 0);

   /// <summary>
   /// A(n) ronnacandela. Defined in terms of a(n) yottacandela.
   /// </summary>
   public static readonly LuminousIntensity Ronnacandela = new ("ronnacandela", "Rcd", Yottacandela, 1000.0, 0);

   /// <summary>
   /// A(n) quettacandela. Defined in terms of a(n) ronnacandela.
   /// </summary>
   public static readonly LuminousIntensity Quettacandela = new ("quettacandela", "Qcd", Ronnacandela, 1000.0, 0);
}
