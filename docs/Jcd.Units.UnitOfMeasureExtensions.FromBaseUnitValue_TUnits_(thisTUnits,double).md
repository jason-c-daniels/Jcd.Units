### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.FromBaseUnitValue<TUnits>(this TUnits, double) Method

Given a raw value, convert TO the fundamental base unit representation FROM the non-base unit representation of  
the value. (e.g. 100mm becomes 0.1 as meters are the base unit)

```csharp
public static double FromBaseUnitValue<TUnits>(this TUnits unitOfMeasure, double value)
    where TUnits : Jcd.Units.IUnitOfMeasure<TUnits>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).TUnits'></a>

`TUnits`

The type of unit
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).unitOfMeasure'></a>

`unitOfMeasure` [TUnits](Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).md#Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).TUnits 'Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue<TUnits>(this TUnits, double).TUnits')

The unit of measure

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnits_(thisTUnits,double).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the denormalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The normalized value