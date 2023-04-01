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
/// Units used in theoretical physics for measuring Volume.
/// </summary>
public class Volumes : UnitOfMeasureEnumeration<Volumes, Volume>
{
   /// <summary>
   /// cubic planck-length, defined as: SI cubic meter × (1.616255E-35)*(1.616255E-35)*(1.616255E-35)
   /// </summary>
   public static readonly Volume CubicPlanckLength = new (
                                                          "cubic planck-length"
                                                        , "ℓₚ³"
                                                        , SI.Volumes.CubicMeter
                                                        , 1.616255E-35 * 1.616255E-35 * 1.616255E-35
                                                        , system: "Theoretical Physics"
                                                         );
}
