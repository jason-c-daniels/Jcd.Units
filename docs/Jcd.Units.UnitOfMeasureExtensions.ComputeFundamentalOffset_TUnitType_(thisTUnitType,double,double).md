#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this TUnitType, double, double) Method

Given a [baseUnit](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).baseUnit 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this TUnitType, double, double).baseUnit') and an offset, calculate the equivalent  
offset for the fundamental unit of measure. (i.e. the one with Coeff = 1 and Offset = 0)

```csharp
public static double ComputeFundamentalOffset<TUnitType>(this TUnitType baseUnit, double fundamentalCoefficient, double offset)
    where TUnitType : Jcd.Units.IUnitOfMeasure<TUnitType>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).TUnitType'></a>

`TUnitType`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).baseUnit'></a>

`baseUnit` [TUnitType](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this TUnitType, double, double).TUnitType')

The base unit of measure to use.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).fundamentalCoefficient'></a>

`fundamentalCoefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient for converting to the fundamental unit of measure.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisTUnitType,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The offset for the fundamental unit of measure.