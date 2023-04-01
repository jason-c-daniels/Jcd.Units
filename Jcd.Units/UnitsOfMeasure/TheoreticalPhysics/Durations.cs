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
/// Units used in theoretical physics for measuring Duration.
/// </summary>
public class Durations : UnitOfMeasureEnumeration<Durations, Duration>
{
   /// <summary>
   /// planck-time, defined as:  microsecond × 5.391247E-38
   /// </summary>
   public static readonly Duration PlanckTime = new (
                                                     "planck-time"
                                                   , "tₚ"
                                                   , UnitsOfMeasure.Durations.Microsecond
                                                   , 5.391247E-38
                                                   , system: "Theoretical Physics"
                                                    );
}
