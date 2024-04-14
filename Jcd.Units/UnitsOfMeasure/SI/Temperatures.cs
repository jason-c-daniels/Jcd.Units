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
   /// degrees celsius, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this
   /// type.)
   /// </summary>
   public static readonly Temperature DegreesCelsius = new("degrees celsius", "°C", system: "SI");
   
   /// <summary>
   /// degrees kelvin defined such that: degrees celsius = °K + -273.15
   /// </summary>
   public static readonly Temperature DegreesKelvin = new("degrees kelvin", "°K", DegreesCelsius, offset: -273.15, system: "SI");
}