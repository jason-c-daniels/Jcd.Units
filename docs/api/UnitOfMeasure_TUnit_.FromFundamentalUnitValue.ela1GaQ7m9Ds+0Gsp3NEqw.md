#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.FromFundamentalUnitValue(double) Method

The interface defining what every unit of measure must support.

```csharp
public double FromFundamentalUnitValue(double normalizedValue);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.FromFundamentalUnitValue(double).normalizedValue'></a>

`normalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Implements [FromFundamentalUnitValue(double)](IUnitOfMeasure_TUnit_.FromFundamentalUnitValue.HjMaJtc3CT4c+JTAgOGaqg.md 'Jcd.Units.IUnitOfMeasure<TUnit>.FromFundamentalUnitValue(double)')

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

### Remarks
By ensuring that all units of measure provide their own type to the interface  
we guarantee compile time detection of certain classes of errors.