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
   /// earth mass defined such that: SI kilogram = M(⊕) × 5.9722E+24.
   /// </summary>
   public static readonly Mass EarthMass = new (
                                                "earth mass"
                                              , "M(⊕)"
                                              , SI.Masses.Kilogram
                                              , 5.9722E+24
                                              , system: "Astronomical"
                                               );

   /// <summary>
   /// jovian mass defined such that: SI kilogram = M(J) × 1.89813E+27.
   /// </summary>
   public static readonly Mass JovianMass = new (
                                                 "jovian mass"
                                               , "M(J)"
                                               , SI.Masses.Kilogram
                                               , 1.89813E+27
                                               , system: "Astronomical"
                                                );

   /// <summary>
   /// lunar mass defined such that: SI kilogram = M(L) × 7.35E+22.
   /// </summary>
   public static readonly Mass LunarMass = new (
                                                "lunar mass"
                                              , "M(L)"
                                              , SI.Masses.Kilogram
                                              , 7.35E+22
                                              , system: "Astronomical"
                                               );

   /// <summary>
   /// mars mass defined such that: SI kilogram = M(♂) × 6.39E+23.
   /// </summary>
   public static readonly Mass MarsMass = new (
                                               "mars mass"
                                             , "M(♂)"
                                             , SI.Masses.Kilogram
                                             , 6.39E+23
                                             , system: "Astronomical"
                                              );

   /// <summary>
   /// solar mass defined such that: SI kilogram = M(☉) × 1.989E+30.
   /// </summary>
   public static readonly Mass SolarMass = new (
                                                "solar mass"
                                              , "M(☉)"
                                              , SI.Masses.Kilogram
                                              , 1.989E+30
                                              , system: "Astronomical"
                                               );
}
