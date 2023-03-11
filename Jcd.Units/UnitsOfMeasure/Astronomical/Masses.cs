#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.Astronomical;

/// <summary>
/// Astronomical Units for measuring Mass.
/// </summary>
public class Masses : Enumeration<Masses, Mass>
{
   /// <summary>
   /// A(n) earth mass. Defined in terms of a(n) SI kilogram.
   /// </summary>
   public static readonly Mass EarthMass = new ("earth mass", "M(⊕)", SI.Masses.Kilogram, 5.9722E+24, 0);

   /// <summary>
   /// A(n) jovian mass. Defined in terms of a(n) SI kilogram.
   /// </summary>
   public static readonly Mass JovianMass = new ("jovian mass", "M(J)", SI.Masses.Kilogram, 1.89813E+27, 0);

   /// <summary>
   /// A(n) lunar mass. Defined in terms of a(n) SI kilogram.
   /// </summary>
   public static readonly Mass LunarMass = new ("lunar mass", "M(L)", SI.Masses.Kilogram, 7.35E+22, 0);

   /// <summary>
   /// A(n) mars mass. Defined in terms of a(n) SI kilogram.
   /// </summary>
   public static readonly Mass MarsMass = new ("mars mass", "M(♂)", SI.Masses.Kilogram, 6.39E+23, 0);

   /// <summary>
   /// A(n) solar mass. Defined in terms of a(n) SI kilogram.
   /// </summary>
   public static readonly Mass SolarMass = new ("solar mass", "M(☉)", SI.Masses.Kilogram, 1.989E+30, 0);
}
