#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this IUnitOfMeasure<TUnitType>, double) Method

Given a [baseUnit](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).baseUnit 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double).baseUnit') and a coefficient, calculate the equivalent  
coefficient for the fundamental unit of measure. (i.e. the one with Coeff. = 1 and Offset = 0)

```csharp
public static double ComputeFundamentalCoefficient<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType> baseUnit, double coefficient);
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).TUnitType'></a>

`TUnitType`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).baseUnit'></a>

`baseUnit` [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')[TUnitType](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this Jcd.Units.IUnitOfMeasure<TUnitType>, double).TUnitType')[&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

The base unit of measure to use.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisJcd.Units.IUnitOfMeasure_TUnitType_,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The coefficient for the fundamental unit of measure.