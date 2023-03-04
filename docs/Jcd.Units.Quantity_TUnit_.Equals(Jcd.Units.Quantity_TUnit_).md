#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.Equals(Quantity<TUnit>) Method

Compares this instance to another [Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>') instance for equality.

```csharp
public bool Equals(Jcd.Units.Quantity<TUnit> other);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnit_.Equals(Jcd.Units.Quantity_TUnit_).other'></a>

`other` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')[TUnit](Jcd.Units.Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')[&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

The other instance to compare against.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if equivalent. False otherwise.

### Remarks
The quantity with the smaller unit of measure is converted to the double representation of  
the larger unit of measure before comparison.