﻿#region

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
   /// A(n) earth mass. Defined as: 5.9722E+24 × SI kilogram.
   /// </summary>
   public static readonly Mass EarthMass = new ("earth mass", "M(⊕)", SI.Masses.Kilogram, 5.9722E+24, 0);

   /// <summary>
   /// A(n) jovian mass. Defined as: 1.89813E+27 × SI kilogram.
   /// </summary>
   public static readonly Mass JovianMass = new ("jovian mass", "M(J)", SI.Masses.Kilogram, 1.89813E+27, 0);

   /// <summary>
   /// A(n) lunar mass. Defined as: 7.35E+22 × SI kilogram.
   /// </summary>
   public static readonly Mass LunarMass = new ("lunar mass", "M(L)", SI.Masses.Kilogram, 7.35E+22, 0);

   /// <summary>
   /// A(n) mars mass. Defined as: 6.39E+23 × SI kilogram.
   /// </summary>
   public static readonly Mass MarsMass = new ("mars mass", "M(♂)", SI.Masses.Kilogram, 6.39E+23, 0);

   /// <summary>
   /// A(n) solar mass. Defined as: 1.989E+30 × SI kilogram.
   /// </summary>
   public static readonly Mass SolarMass = new ("solar mass", "M(☉)", SI.Masses.Kilogram, 1.989E+30, 0);

   /// <summary>
   /// A(n) planck-mass. Defined as: 2.176434E-8 × SI kilogram.
   /// </summary>
   public static readonly Mass PlanckMass = new ("planck-mass", "mₚ", SI.Masses.Kilogram, 2.176434E-8, 0);
}
