namespace Jcd.Units;

/// <summary>
/// Extension methods that convert raw values to and from fundamental
/// (Coefficient=1, Offset=0) unit of measure representations.
/// </summary>
public static class UnitOfMeasureExtensions
{
    /// <summary>
    /// Given a raw value, convert FROM the fundamental base unit representation
    /// TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base
    /// unit and 0.1m is 100mm )
    /// </summary>
    /// <param name="targetUnit">The unit of measure to convert TO</param>
    /// <param name="value">the normalized value.</param>
    /// <typeparam name="TUnitType">The type of unit of measure (e.g. Length)</typeparam>
    /// <returns>The denormalized value</returns>
    public static double FromBaseUnitValue<TUnitType>(this TUnitType targetUnit, double value)
        where TUnitType : IUnitOfMeasure<TUnitType>
    {
        return (value / targetUnit.Coefficient)  - targetUnit.Offset;
    }

    /// <summary>
    /// Given a raw value, convert TO the fundamental base unit representation
    /// FROM the non-base unit representation of  the value. (e.g. 100mm becomes
    /// 0.1 as meters are the base unit)
    /// </summary>
    /// <param name="sourceUnit">The unit of measure to convert FROM</param>
    /// <param name="value">the denormalized value.</param>
    /// <typeparam name="TUnitType">The type of unit of measure (e.g. Length)</typeparam>
    public static double ToBaseUnitValue<TUnitType>(this TUnitType sourceUnit, double value)
        where TUnitType : IUnitOfMeasure<TUnitType>
    {
        return (value + sourceUnit.Offset) * sourceUnit.Coefficient;
    }
}