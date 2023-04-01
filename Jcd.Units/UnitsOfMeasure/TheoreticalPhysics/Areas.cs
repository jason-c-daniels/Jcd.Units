#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.TheoreticalPhysics;

/// <summary>
/// Units used in theoretical physics for measuring Area.
/// </summary>
public class Areas : UnitOfMeasureEnumeration<Areas, Area>
{
   /// <summary>
   /// square planck-length, defined as: SI square meter × (1.616255E-35)*(1.616255E-35)
   /// </summary>
   public static readonly Area SquarePlanckLength = new (
                                                         "square planck-length"
                                                       , "ℓₚ²"
                                                       , SI.Areas.SquareMeter
                                                       , 1.616255E-35 * 1.616255E-35
                                                        );
}
