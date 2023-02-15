### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ToBaseUnitValue<TUnits>(this TUnits, double) Method

Given a raw value, convert FROM the fundamental base unit representation TO the non-base value. (e.g. 0.1  
becomes 100mm as meters are the base unit and 0.1m is 100mm )

```csharp
public static double ToBaseUnitValue<TUnits>(this TUnits unitOfMeasure, double value)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).TUnits'></a>

`TUnits`

The type of unit
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).md#Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).TUnits 'Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue<TUnits>(this TUnits, double).TUnits')

The unit of measure

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnits_(thisTUnits,double).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the normalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The denormalized value