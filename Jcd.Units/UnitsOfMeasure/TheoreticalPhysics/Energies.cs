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
/// Units used in theoretical physics for measuring Energy.
/// </summary>
public class Energies : UnitOfMeasureEnumeration<Energies, Energy>
{
   /// <summary>
   /// planck-energy defined such that: SI joule = Eₚ × 1.9561E+9.
   /// </summary>
   public static readonly Energy PlanckEnergy = new (
                                                     "planck-energy"
                                                   , "Eₚ"
                                                   , SI.Energies.Joule
                                                   , 1.9561E+9
                                                   , system: "Theoretical Physics"
                                                    );
}
