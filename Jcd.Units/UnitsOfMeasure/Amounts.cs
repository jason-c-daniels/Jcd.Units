using Jcd.Units.UnitTypes;
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedType.Global


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

    /// <summary>
    /// A(n) quantity. Defined in terms of a(n) count.
    /// </summary>
    public static readonly Amount Quantity = new ("quantity", "qty.", Count, 1,0);

}