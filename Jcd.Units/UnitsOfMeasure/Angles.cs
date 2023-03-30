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
   /// degree, defined as: SI radian × (180.0/Math.PI)
   /// </summary>
   public static readonly Angle Degree = new ("degree", "°", SI.Angles.Radian, 180.0 / Math.PI);

   /// <summary>
   /// arc minute, defined as: degree × 1.0/60.0
   /// </summary>
   public static readonly Angle ArcMinute = new ("arc minute", "′", Degree, 1.0 / 60.0);

   /// <summary>
   /// arc second, defined as: arc minute × 1.0/60.0
   /// </summary>
   public static readonly Angle ArcSecond = new ("arc second", "″", ArcMinute, 1.0 / 60.0);

   /// <summary>
   /// gradian, defined as: SI radian × (Math.PI/200.0)
   /// </summary>
   public static readonly Angle Gradian = new ("gradian", "ᵍ", SI.Angles.Radian, Math.PI / 200.0);
}
