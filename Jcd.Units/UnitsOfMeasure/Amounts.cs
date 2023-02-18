using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

/// <summary>
/// Uncategorized Units for measuring Amount.
/// </summary>
public class Amounts : Enumeration<Amounts,Amount>
{
    public static readonly Amount Count = new ("count", "ct.");
}