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
/// Units used in theoretical physics for measuring Length.
/// </summary>
public class Lengths : UnitOfMeasureEnumeration<Lengths, Length>
{
   /// <summary>
   /// planck-length, defined as: SI meter × 1.616255E-35
   /// </summary>
   public static readonly Length PlanckLength = new (
                                                     "planck-length"
                                                   , "ℓₚ"
                                                   , SI.Lengths.Meter
                                                   , 1.616255E-35
                                                   , system: "Theoretical Physics"
                                                    );
}
