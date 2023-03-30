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
/// Astronomical Units for measuring Force.
/// </summary>
public class Forces : UnitOfMeasureEnumeration<Forces, Force>
{
   /// <summary>
   /// planck-force, defined as: SI newton × 1.2103E+44
   /// </summary>
   public static readonly Force PlanckForce = new ("planck-force", "Fₚ", SI.Forces.Newton, 1.2103E+44);
}
