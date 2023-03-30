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
public class Masses : UnitOfMeasureEnumeration<Masses, Mass>
{
   /// <summary>
   /// earth mass, defined as: SI kilogram × 5.9722E+24
   /// </summary>
   public static readonly Mass EarthMass = new ("earth mass", "M(⊕)", SI.Masses.Kilogram, 5.9722E+24);

   /// <summary>
   /// jovian mass, defined as: SI kilogram × 1.89813E+27
   /// </summary>
   public static readonly Mass JovianMass = new ("jovian mass", "M(J)", SI.Masses.Kilogram, 1.89813E+27);

   /// <summary>
   /// lunar mass, defined as: SI kilogram × 7.35E+22
   /// </summary>
   public static readonly Mass LunarMass = new ("lunar mass", "M(L)", SI.Masses.Kilogram, 7.35E+22);

   /// <summary>
   /// mars mass, defined as: SI kilogram × 6.39E+23
   /// </summary>
   public static readonly Mass MarsMass = new ("mars mass", "M(♂)", SI.Masses.Kilogram, 6.39E+23);

   /// <summary>
   /// solar mass, defined as: SI kilogram × 1.989E+30
   /// </summary>
   public static readonly Mass SolarMass = new ("solar mass", "M(☉)", SI.Masses.Kilogram, 1.989E+30);

   /// <summary>
   /// planck-mass, defined as: SI kilogram × 2.176434E-8
   /// </summary>
   public static readonly Mass PlanckMass = new ("planck-mass", "mₚ", SI.Masses.Kilogram, 2.176434E-8);
}
