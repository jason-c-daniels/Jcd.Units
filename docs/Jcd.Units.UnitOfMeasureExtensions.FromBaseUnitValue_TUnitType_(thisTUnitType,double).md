#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.FromBaseUnitValue<TUnitType>(this TUnitType, double) Method

Given a raw value, convert FROM the fundamental base unit representation  
TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base  
unit and 0.1m is 100mm )

```csharp
public static double FromBaseUnitValue<TUnitType>(this TUnitType targetUnit, double value)
    where TUnitType : Jcd.Units.IUnitOfMeasure<TUnitType>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).TUnitType'></a>

`TUnitType`

The type of unit of measure (e.g. Length)
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).targetUnit'></a>

`targetUnit` [TUnitType](Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).md#Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue<TUnitType>(this TUnitType, double).TUnitType')

The unit of measure to convert TO

<a name='Jcd.Units.UnitOfMeasureExtensions.FromBaseUnitValue_TUnitType_(thisTUnitType,double).value'></a>

`value` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the normalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The denormalized value