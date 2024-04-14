#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Temperature.
/// </summary>
public class Temperatures : UnitOfMeasureEnumeration<Temperatures, Temperature>
{
   /// <summary>
   /// degrees rankine defined such that: SI degrees kelvin = °R × 5.0/9.0.
   /// </summary>
   public static readonly Temperature DegreesRankine = new("degrees rankine", "°R", SI.Temperatures.DegreesKelvin, 5.0 / 9.0, system: "");
   
   /// <summary>
   /// degrees delisle defined such that: SI degrees celsius = (°De + -150) × -2.0/3.0.
   /// </summary>
   public static readonly Temperature DegreesDelisle = new("degrees delisle", "°De", SI.Temperatures.DegreesCelsius, -2.0 / 3.0, -150, system: "");
   
   /// <summary>
   /// degrees newton defined such that: SI degrees celsius = °N × 100.0/33.0.
   /// </summary>
   public static readonly Temperature DegreesNewton = new("degrees newton", "°N", SI.Temperatures.DegreesCelsius, 100.0 / 33.0, system: "");
   
   /// <summary>
   /// degrees réaumur defined such that: SI degrees celsius = °Ré × 5.0/4.0.
   /// </summary>
   public static readonly Temperature DegreesRéaumur = new("degrees réaumur", "°Ré", SI.Temperatures.DegreesCelsius, 5.0 / 4.0, system: "");
   
   /// <summary>
   /// degrees rømer defined such that: SI degrees celsius = (°Rø + -7.5) × 40.0/21.0.
   /// </summary>
   public static readonly Temperature DegreesRømer = new("degrees rømer", "°Rø", SI.Temperatures.DegreesCelsius, 40.0 / 21.0, -7.5, system: "");
}