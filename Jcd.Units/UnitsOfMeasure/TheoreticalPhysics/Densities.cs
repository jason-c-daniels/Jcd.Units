#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.TheoreticalPhysics;

/// <summary>
/// Units used in theoretical physics for measuring Density.
/// </summary>
public class Densities : UnitOfMeasureEnumeration<Densities, Density>
{
   /// <summary>
   /// planck-density defined such that: SI kilogram per cubic meter = ρₚ × 5.1550E+96.
   /// </summary>
   public static readonly Density PlanckDensity = new (
                                                       "planck-density"
                                                     , "ρₚ"
                                                     , SI.Densities.KilogramPerCubicMeter
                                                     , 5.1550E+96
                                                     , system: "Theoretical Physics"
                                                      );
}
