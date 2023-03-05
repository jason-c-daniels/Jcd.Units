#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.ToBaseUnitValue(double) Method

The interface defining what every unit of measure must support.

```csharp
public double ToBaseUnitValue(double denormalizedValue);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.ToBaseUnitValue(double).denormalizedValue'></a>

`denormalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [ToBaseUnitValue(double)](Jcd.Units.IUnitOfMeasure_TUnit_.ToBaseUnitValue(double).md 'Jcd.Units.IUnitOfMeasure<TUnit>.ToBaseUnitValue(double)')

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.