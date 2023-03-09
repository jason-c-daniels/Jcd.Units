#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.GetHashCode() Method

Computes a hashcode for the quantity, so that numeric equivalence is maintained  
regardless of precise unit of measure is used, the hashcode is calculated on  
the fundamental unit representation. TUnit is included in the hashcode to ensure  
that differing units do not hash the same.

```csharp
public override int GetHashCode();
```

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The calculated hashcode.