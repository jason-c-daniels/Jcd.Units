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
/// Uncategorized Units for measuring Angle.
/// </summary>
public class Angles : UnitOfMeasureEnumeration<Angles, Angle>
{
   /// <summary>
   /// radian, the basis for all units of measure of this type. (i.e. the fundamental unit of measure for this type.)
   /// </summary>
   public static readonly Angle Radian = new ("radian", "rad", system: "");

   /// <summary>
   /// degree, defined as: radian × (180.0/Math.PI)
   /// </summary>
   public static readonly Angle Degree = new ("degree", "°", Radian, 180.0 / Math.PI, system: "");

   /// <summary>
   /// arc minute, defined as: degree × 1.0/60.0
   /// </summary>
   public static readonly Angle ArcMinute = new ("arc minute", "′", Degree, 1.0 / 60.0, system: "");

   /// <summary>
   /// arc second, defined as: arc minute × 1.0/60.0
   /// </summary>
   public static readonly Angle ArcSecond = new ("arc second", "″", ArcMinute, 1.0 / 60.0, system: "");

   /// <summary>
   /// gradian, defined as: radian × (Math.PI/200.0)
   /// </summary>
   public static readonly Angle Gradian = new ("gradian", "ᵍ", Radian, Math.PI / 200.0, system: "");
}
