using Jcd.Units.UnitTypes;

namespace Jcd.Units.UnitsOfMeasure;

public class Amounts : Enumeration<Amounts,Amount>
{
    public static readonly Amount Count = new ("count", "ct.");
}