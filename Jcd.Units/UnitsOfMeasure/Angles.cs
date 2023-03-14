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
public class Angles : Enumeration<Angles, Angle>
{
   /// <summary>
   /// A(n) degree. Defined in terms of a(n) SI radian.
   /// </summary>
   public static readonly Angle Degree = new ("degree", "°", SI.Angles.Radian, 180.0 / Math.PI, 0);

   /// <summary>
   /// A(n) arc minute. Defined in terms of a(n) degree.
   /// </summary>
   public static readonly Angle ArcMinute = new ("arc minute", "′", Degree, 1.0 / 60.0, 0);

   /// <summary>
   /// A(n) arc second. Defined in terms of a(n) arc minute.
   /// </summary>
   public static readonly Angle ArcSecond = new ("arc second", "″", ArcMinute, 1.0 / 60.0, 0);
}
