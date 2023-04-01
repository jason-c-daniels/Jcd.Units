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
/// Units used in theoretical physics for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// planck-temperature, defined as: SI degrees kelvin × 1.416784E+32
   /// </summary>
   public static readonly Temperature PlanckTemperature = new (
                                                               "planck-temperature"
                                                             , "Tₚ"
                                                             , SI.Temperatures.DegreesKelvin
                                                             , 1.416784E+32
                                                              );
}
