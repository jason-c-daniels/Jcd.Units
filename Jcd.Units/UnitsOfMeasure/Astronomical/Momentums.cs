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
/// Astronomical Units for measuring Momentum.
/// </summary>
public class Momentums : UnitOfMeasureEnumeration<Momentums, Momentum>
{
   /// <summary>
   /// A(n) planck-momentum. Defined as: (6.5249) × SI newton-second + (0).
   /// </summary>
   public static readonly Momentum PlanckMomentum = new (
                                                         "planck-momentum"
                                                       , "mₚc"
                                                       , SI.Momentums.NewtonSecond
                                                       , 6.5249
                                                       , 0
                                                        );
}
