#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[IUnitOfMeasure&lt;TUnit&gt;](IUnitOfMeasure_TUnit_.md 'Jcd.Units.IUnitOfMeasure<TUnit>')

## IUnitOfMeasure<TUnit>.ToBaseUnitValue(double) Method

Given a raw value, convert TO the fundamental base unit representation  
FROM the non-base unit representation of  the value. (e.g. 100mm becomes  
0.1 as meters are the base unit)

```csharp
double ToBaseUnitValue(double denormalizedValue);
```
#### Parameters

<a name='Jcd.Units.IUnitOfMeasure_TUnit_.ToBaseUnitValue(double).denormalizedValue'></a>

`denormalizedValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

the denormalized value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')