#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasureExtensions](Jcd.Units.UnitOfMeasureExtensions.md 'Jcd.Units.UnitOfMeasureExtensions')

## UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this TUnitType, double) Method

Given a [baseUnit](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).baseUnit 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this TUnitType, double).baseUnit') and a coefficient, calculate the equivalent  
coefficient for the fundamental unit of measure. (i.e. the one with Coeff. = 1 and Offset = 0)

```csharp
public static double ComputeFundamentalCoefficient<TUnitType>(this TUnitType baseUnit, double coefficient)
    where TUnitType : Jcd.Units.IUnitOfMeasure<TUnitType>;
```
#### Type parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).TUnitType'></a>

`TUnitType`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).baseUnit'></a>

`baseUnit` [TUnitType](Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).md#Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).TUnitType 'Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient<TUnitType>(this TUnitType, double).TUnitType')

The base unit of measure to use.

<a name='Jcd.Units.UnitOfMeasureExtensions.ComputeFundamentalCoefficient_TUnitType_(thisTUnitType,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The coefficient for the fundamental unit of measure.