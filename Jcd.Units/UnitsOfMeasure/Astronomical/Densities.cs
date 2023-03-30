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
/// Astronomical Units for measuring Density.
/// </summary>
public class Densities : UnitOfMeasureEnumeration<Densities, Density>
{
   /// <summary>
   /// A(n) planck-density. Defined as: 5.1550E+96 × SI kilogram per cubic meter.
   /// </summary>
   public static readonly Density PlanckDensity = new (
                                                       "planck-density"
                                                     , "ρₚ"
                                                     , SI.Densities.KilogramPerCubicMeter
                                                     , 5.1550E+96
                                                     , 0
                                                      );
}
