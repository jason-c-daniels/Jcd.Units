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
/// Astronomical Units for measuring Energy.
/// </summary>
public class Energies : UnitOfMeasureEnumeration<Energies, Energy>
{
   /// <summary>
   /// planck-energy, defined as: SI joule × 1.9561E+9
   /// </summary>
   public static readonly Energy PlanckEnergy = new ("planck-energy", "Eₚ", SI.Energies.Joule, 1.9561E+9);
}
