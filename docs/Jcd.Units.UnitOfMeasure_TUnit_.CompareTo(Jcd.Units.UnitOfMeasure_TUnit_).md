#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.CompareTo(UnitOfMeasure<TUnit>) Method

Performs a relative comparison between this [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') and another one.

```csharp
public int CompareTo(Jcd.Units.UnitOfMeasure<TUnit>? other);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.CompareTo(Jcd.Units.UnitOfMeasure_TUnit_).other'></a>

`other` [Jcd.Units.UnitOfMeasure&lt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')[TUnit](Jcd.Units.UnitOfMeasure_TUnit_.md#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')[&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

The [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if less than; 1 if greater than; 0 if equals.