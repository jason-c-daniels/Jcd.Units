#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[IUnitOfMeasure&lt;TUnit&gt;](Jcd.Units.IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

## IUnitOfMeasure<TUnit>.ComputeFundamentalOffset(double, double) Method

Given an offset and the coefficient for converting to the fundamental unit  
of measure, calculate the equivalent offset for the fundamental unit of measure.  
(i.e. the one with Coeff = 1 and Offset = 0)

```csharp
double ComputeFundamentalOffset(double fundamentalCoefficient, double offset);
```
#### Parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.ComputeFundamentalOffset(double,double).fundamentalCoefficient'></a>

`fundamentalCoefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient for converting to the fundamental unit of measure.

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.ComputeFundamentalOffset(double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset to normalize.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The offset for the fundamental unit of measure.