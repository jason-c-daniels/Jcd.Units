#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[IUnitOfMeasure&lt;TUnit&gt;](IUnitOfMeasure_TUnit_ 'Jcd.Units.IUnitOfMeasure<TUnit>')

## IUnitOfMeasure<TUnit>.ComputeFundamentalCoefficient(double) Method

Given a coefficient, calculate the equivalent coefficient for the
fundamental unit of measure. (i.e. the one with Coeff. = 1 and Offset = 0)

```csharp
double ComputeFundamentalCoefficient(double coefficient);
```
#### Parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.ComputeFundamentalCoefficient(double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The coefficient for the fundamental unit of measure.