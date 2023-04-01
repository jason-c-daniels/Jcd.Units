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
/// Units used in theoretical physics for measuring Mass.
/// </summary>
public class Masses : UnitOfMeasureEnumeration<Masses, Mass>
{
   /// <summary>
   /// planck-mass defined such that: SI kilogram = mₚ × 2.176434E-8.
   /// </summary>
   public static readonly Mass PlanckMass = new (
                                                 "planck-mass"
                                               , "mₚ"
                                               , SI.Masses.Kilogram
                                               , 2.176434E-8
                                               , system: "Theoretical Physics"
                                                );
}
