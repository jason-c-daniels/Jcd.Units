#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.ComputeFundamentalOffset(double, double) Method

The interface defining what every unit of measure must support.

```csharp
public double ComputeFundamentalOffset(double fundamentalCoefficient, double offset);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.ComputeFundamentalOffset(double,double).fundamentalCoefficient'></a>

`fundamentalCoefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.ComputeFundamentalOffset(double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [ComputeFundamentalOffset(double, double)](IUnitOfMeasure_TUnit_.ComputeFundamentalOffset.dHShegAVwvw43wIz21vDUw.md 'Jcd.Units.IUnitOfMeasure<TUnit>.ComputeFundamentalOffset(double, double)')

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.