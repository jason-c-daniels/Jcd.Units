#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// A(n) degrees fahrenheit. Defined as: (5.0/9.0 + -32.0) × SI degrees celcius.
   /// </summary>
   public static readonly Temperature DegreesFahrenheit = new (
                                                               "degrees fahrenheit"
                                                             , "°F"
                                                             , SI.Temperatures.DegreesCelcius
                                                             , 5.0 / 9.0
                                                             , -32.0
                                                              );
}
