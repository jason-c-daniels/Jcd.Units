#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

## Quantity<TUnits>.CompareTo(Quantity<TUnits>) Method

Compares this instance to another [Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>') instance for relative value.

```csharp
public int CompareTo(Jcd.Units.Quantity<TUnits> other);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnits_.CompareTo(Jcd.Units.Quantity_TUnits_).other'></a>

`other` [Jcd.Units.Quantity&lt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')[TUnits](Jcd.Units.Quantity_TUnits_.md#Jcd.Units.Quantity_TUnits_.TUnits 'Jcd.Units.Quantity<TUnits>.TUnits')[&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

The other instance to compare against.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
-1 if this instance is less than the other; 1 if this instance is greater than the other; 0 if equivalent.