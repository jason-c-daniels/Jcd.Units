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
public class Angles : UnitOfMeasureEnumeration<Angles, Angle>
{
   /// <summary>
   /// A(n) radian.
   /// </summary>
   public static readonly Angle Radian = new ("radian", "rad");
}
