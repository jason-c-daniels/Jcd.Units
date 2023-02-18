#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnits&gt;](Jcd.Units.Quantity_TUnits_.md 'Jcd.Units.Quantity<TUnits>')

## Quantity<TUnits>.GetHashCode() Method

Computes a hashcode for the quantity. So that numeric equivalence is maintained  
regardless of precise unit of measure is used, the hashcode is calculated on  
the base unit representation. TUnits is included in the hashcode to ensure  
that differing units do not compare the same.

```csharp
public override int GetHashCode();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The calculated hashcode.