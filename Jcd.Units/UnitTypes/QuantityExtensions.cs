namespace Jcd.Units.UnitTypes;

public static class QuantityExtensions
{
    public static Quantity<TUnits> As<TUnits>(this double rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    public static Quantity<TUnits> As<TUnits>(this float rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    public static Quantity<TUnits> As<TUnits>(this int rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    public static Quantity<TUnits> As<TUnits>(this uint rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    public static Quantity<TUnits> As<TUnits>(this short rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }

    public static Quantity<TUnits> As<TUnits>(this ushort rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    public static Quantity<TUnits> As<TUnits>(this sbyte rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
    
    public static Quantity<TUnits> As<TUnits>(this byte rawValue, TUnits unitOfMeasure)
        where TUnits : IUnitOfMeasure<TUnits>
    {
        return new Quantity<TUnits>(rawValue, unitOfMeasure);
    }
}