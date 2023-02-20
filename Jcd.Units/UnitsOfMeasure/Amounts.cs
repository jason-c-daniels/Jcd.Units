using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global


namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Amount.
/// </summary>
public class Amounts : Enumeration<Amounts,Amount>
{

    /// <summary>
    /// A(n) count.
    /// </summary>
    public static readonly Amount Count = new ("count", "ct.");

}