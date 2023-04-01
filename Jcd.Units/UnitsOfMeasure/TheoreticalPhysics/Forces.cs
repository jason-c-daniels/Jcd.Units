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
/// Units used in theoretical physics for measuring Force.
/// </summary>
public class Forces : UnitOfMeasureEnumeration<Forces, Force>
{
   /// <summary>
   /// planck-force defined such that: SI newton = Fₚ × 1.2103E+44.
   /// </summary>
   public static readonly Force PlanckForce = new (
                                                   "planck-force"
                                                 , "Fₚ"
                                                 , SI.Forces.Newton
                                                 , 1.2103E+44
                                                 , system: "Theoretical Physics"
                                                  );
}
