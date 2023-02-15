namespace Jcd.Units;

public static class UnitOfMeasureExtensions
{
    /// <summary>
    /// Given a raw value, convert TO the fundamental base unit representation FROM the non-base unit representation of
    /// the value. (e.g. 100mm becomes 0.1 as meters are the base unit)
    /// </summary>
    /// <param name="unitOfMeasure">The unit of measure</param>
    /// <param name="value">the denormalized value.</param>
    /// <typeparam name="TUnits">The type of unit</typeparam>
    /// <returns>The normalized value</returns>
    public static double FromBaseUnitValue<TUnits>(this TUnits unitOfMeasure, double value)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return (value / unitOfMeasure.Coefficient)  - unitOfMeasure.Offset;
    }
    
    /// <summary>
    /// Given a raw value, convert FROM the fundamental base unit representation TO the non-base value. (e.g. 0.1
    /// becomes 100mm as meters are the base unit and 0.1m is 100mm )
    /// </summary>
    /// <param name="unitOfMeasure">The unit of measure</param>
    /// <param name="value">the normalized value.</param>
    /// <typeparam name="TUnits">The type of unit</typeparam>
    /// <returns>The denormalized value</returns>
    public static double ToBaseUnitValue<TUnits>(this TUnits unitOfMeasure, double value)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return (value + unitOfMeasure.Offset) * unitOfMeasure.Coefficient;
    }
}