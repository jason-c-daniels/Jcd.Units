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
   /// A(n) degrees celcius.
   /// </summary>
   public static readonly Temperature DegreesCelcius = new ("degrees celcius", "°C");

   /// <summary>
   /// A(n) degrees kelvin. Defined in terms of a(n) degrees celcius.
   /// </summary>
   public static readonly Temperature DegreesKelvin = new ("degrees kelvin", "°K", DegreesCelcius, 1.0, -273.15);
}
