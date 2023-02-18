namespace Jcd.Units;

/// <summary>
/// Some extension methods to make creating quantities using units of measures,
/// and converting among units of measure easier.
/// </summary>
public static class QuantityExtensions
{
    /// <summary>
    /// Converts a <see cref="double"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="double"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this double rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    /// <summary>
    /// Converts a <see cref="float"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="float"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this float rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    /// <summary>
    /// Converts an <see cref="int"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="int"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this int rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    /// <summary>
    /// Converts a <see cref="uint"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="uint"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this uint rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    /// <summary>
    /// Converts a <see cref="short"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="short"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this short rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    /// <summary>
    /// Converts a <see cref="ushort"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="ushort"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this ushort rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    /// <summary>
    /// Converts an <see cref="sbyte"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="sbyte"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this sbyte rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    /// <summary>
    /// Converts a <see cref="byte"/> into a quantity using the specified unit of measure.
    /// </summary>
    /// <param name="rawValue">The <see cref="byte"/> to convert.</param>
    /// <param name="unitOfMeasure">The unit of measure to use.</param>
    /// <typeparam name="TUnits">The type of the unit of measure.</typeparam>
    /// <returns>A new <see cref="Quantity{TUnits}"/> instance.</returns>
    public static Quantity<TUnits> As<TUnits>(this byte rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
}