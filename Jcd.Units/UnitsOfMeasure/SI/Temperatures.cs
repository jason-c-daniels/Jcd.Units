#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.SI;

/// <summary>
/// International System of Units for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// degrees celcius, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Temperature DegreesCelcius = new ("degrees celcius", "°C", system: "SI");

   /// <summary>
   /// degrees kelvin, defined as: degrees celcius + -273.15
   /// </summary>
   public static readonly Temperature DegreesKelvin = new (
                                                           "degrees kelvin"
                                                         , "°K"
                                                         , DegreesCelcius
                                                         , offset: -273.15
                                                         , system: "SI"
                                                          );
}
