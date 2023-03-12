#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.CompareTo(Quantity<TUnit>) Method

Compares this instance to another [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for relative value.

```csharp
public int CompareTo(Jcd.Units.Quantity<TUnit> other);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnit_.CompareTo(Jcd.Units.Quantity_TUnit_).other'></a>

`other` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The other instance to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.

### Remarks
The quantity with the smaller unit of measure is converted to the larger unit of measure  
before comparison.