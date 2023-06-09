#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.ComputeFundamentalCoefficient(double) Method

The interface defining what every unit of measure must support.

```csharp
public double ComputeFundamentalCoefficient(double coefficient);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.ComputeFundamentalCoefficient(double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [ComputeFundamentalCoefficient(double)](IUnitOfMeasure_TUnit_.ComputeFundamentalCoefficient.tl0ngZGU2W+hcEjMFC0Ucw.md 'Jcd.Units.IUnitOfMeasure<TUnit>.ComputeFundamentalCoefficient(double)')

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.