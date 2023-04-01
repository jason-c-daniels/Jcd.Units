#region

using Jcd.Units.UnitTypes;

#endregion

// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global

namespace Jcd.Units.UnitsOfMeasure.USCustomary;

/// <summary>
/// United States Customary Units for measuring Force.
/// </summary>
public class Forces : UnitOfMeasureEnumeration<Forces, Force>
{
   /// <summary>
   /// pound-force defined such that: SI newton = lbf × 4.448222.
   /// </summary>
   public static readonly Force PoundForce = new (
                                                  "pound-force"
                                                , "lbf"
                                                , SI.Forces.Newton
                                                , 4.448222
                                                , system: "US Customary"
                                                 );
}
