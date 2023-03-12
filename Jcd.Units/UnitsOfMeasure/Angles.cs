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
   /// A(n) degrees. Defined in terms of a(n) SI radians.
   /// </summary>
   public static readonly Angle Degrees = new ("degrees", "°", SI.Angles.Radians, 180 / Math.PI, 0);
}
