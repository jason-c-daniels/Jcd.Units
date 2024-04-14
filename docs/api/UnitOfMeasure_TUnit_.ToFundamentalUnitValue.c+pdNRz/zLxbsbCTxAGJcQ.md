#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.ToFundamentalUnitValue(double) Method

The interface defining what every unit of measure must support.

```csharp
public double ToFundamentalUnitValue(double denormalizedValue);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.ToFundamentalUnitValue(double).denormalizedValue'></a>

`denormalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [ToFundamentalUnitValue(double)](IUnitOfMeasure_TUnit_.ToFundamentalUnitValue.9rxgmUYTNn0R4fvkmnqVIA 'Jcd.Units.IUnitOfMeasure<TUnit>.ToFundamentalUnitValue(double)')

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks
By ensuring that all units of measure provide their own type to the interface
we guarantee compile time detection of certain classes of errors.