#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ToBaseUnitValue<TUnitType>(this TUnitType, double) Method

Given a raw value, convert TO the fundamental base unit representation  
FROM the non-base unit representation of  the value. (e.g. 100mm becomes  
0.1 as meters are the base unit)

```csharp
public static double ToBaseUnitValue<TUnitType>(this TUnitType sourceUnit, double value)
    where TUnitType : Jcd.Units.IUnitOfMeasure<TUnitType>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).TUnitType'></a>

`TUnitType`

The type of unit of measure (e.g. Length)
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).sourceUnit'></a>

`sourceUnit` [TUnitType](Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).md#Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue<TUnitType>(this TUnitType, double).TUnitType')

The unit of measure to convert FROM

<a name='Jcd.Units.UnitOfMeasureExtensions.ToBaseUnitValue_TUnitType_(thisTUnitType,double).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the denormalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')