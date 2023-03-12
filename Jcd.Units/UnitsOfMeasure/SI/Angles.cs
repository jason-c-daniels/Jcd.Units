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
/// International System of Units for measuring Angle.
/// </summary>
public class Angles : Enumeration<Angles, Angle>
{
   /// <summary>
   /// A(n) radians.
   /// </summary>
   public static readonly Angle Radians = new ("radians", "rad");
}
