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
   /// A(n) degree. Defined as: ((180.0/Math.PI)) × SI radian + (0).
   /// </summary>
   public static readonly Angle Degree = new ("degree", "°", SI.Angles.Radian, 180.0 / Math.PI, 0);

   /// <summary>
   /// A(n) arc minute. Defined as: (1.0/60.0) × degree + (0).
   /// </summary>
   public static readonly Angle ArcMinute = new ("arc minute", "′", Degree, 1.0 / 60.0, 0);

   /// <summary>
   /// A(n) arc second. Defined as: (1.0/60.0) × arc minute + (0).
   /// </summary>
   public static readonly Angle ArcSecond = new ("arc second", "″", ArcMinute, 1.0 / 60.0, 0);

   /// <summary>
   /// A(n) gradian. Defined as: ((Math.PI/200.0)) × SI radian + (0).
   /// </summary>
   public static readonly Angle Gradian = new ("gradian", "ᵍ", SI.Angles.Radian, Math.PI / 200.0, 0);
}
