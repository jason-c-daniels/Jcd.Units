#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this IUnitOfMeasure<TUnitType>, double) Method

Given a [baseUnit](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).baseUnit 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double).baseUnit') and an offset, calculate the equivalent  
offset for the fundamental unit of measure. (i.e. the one with Coeff = 1 and Offset = 0)

```csharp
public static double ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType> baseUnit, double offset);
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).TUnitType'></a>

`TUnitType`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).baseUnit'></a>

`baseUnit` [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[TUnitType](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double).TUnitType')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

The base unit of measure to use.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalOffset_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The offset for the fundamental unit of measure.