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
/// Units used in theoretical physics for measuring Momentum.
/// </summary>
public class Momentums : UnitOfMeasureEnumeration<Momentums, Momentum>
{
   /// <summary>
   /// planck-momentum, defined as: SI newton-second × 6.5249
   /// </summary>
   public static readonly Momentum PlanckMomentum = new (
                                                         "planck-momentum"
                                                       , "mₚc"
                                                       , SI.Momentums.NewtonSecond
                                                       , 6.5249
                                                       , system: "Theoretical Physics"
                                                        );
}
