#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.IsSynonym(TUnit) Method

Determines if the units of measure are identical in all but system name, name, or symbol.

```csharp
public bool IsSynonym(TUnit other);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.IsSynonym(TUnit).other'></a>

`other` [TUnit](UnitOfMeasure_TUnit_#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')

The unit to compare against.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the coefficient and offset are the same, but symbol, name or system are different.