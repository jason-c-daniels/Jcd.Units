#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[IUnitOfMeasure&lt;TUnit&gt;](IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

## IUnitOfMeasure<TUnit>.FromBaseUnitValue(double) Method

Given a raw value, convert FROM the fundamental (normalized) base unit representation  
TO the non-base value. (e.g. 0.1  becomes 100mm as meters are the base  
unit and 0.1m is 100mm )

```csharp
double FromBaseUnitValue(double normalizedValue);
```
#### Parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.FromBaseUnitValue(double).normalizedValue'></a>

`normalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the normalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The denormalized value