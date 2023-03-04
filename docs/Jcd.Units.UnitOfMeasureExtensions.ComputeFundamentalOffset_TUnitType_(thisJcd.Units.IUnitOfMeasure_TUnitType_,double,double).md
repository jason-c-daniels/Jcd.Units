#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this IUnitOfMeasure<TUnitType>, double, double) Method

Given a [baseUnit](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).baseUnit 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double, double).baseUnit') and an offset, calculate the equivalent  
offset for the fundamental unit of measure. (i.e. the one with Coeff = 1 and Offset = 0)

```csharp
public static double ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType> baseUnit, double fundamentalCoefficient, double offset);
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).TUnitType'></a>

`TUnitType`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).baseUnit'></a>

`baseUnit` [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')[TUnitType](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double, double).TUnitType')[&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

The base unit of measure to use.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).fundamentalCoefficient'></a>

`fundamentalCoefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient for converting to the fundamental unit of measure.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The offset for the fundamental unit of measure.