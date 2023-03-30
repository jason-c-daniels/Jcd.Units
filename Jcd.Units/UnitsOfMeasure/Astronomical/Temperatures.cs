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
/// Astronomical Units for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// A(n) planck-temperature. Defined as: 1.416784E+32 × SI degrees kelvin.
   /// </summary>
   public static readonly Temperature PlanckTemperature = new (
                                                               "planck-temperature"
                                                             , "Tₚ"
                                                             , SI.Temperatures.DegreesKelvin
                                                             , 1.416784E+32
                                                             , 0
                                                              );
}
