#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.GetSymbolLookup<TUnit>() Method

Gets a symbol based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type.

```csharp
public System.Linq.ILookup<string,TUnit> GetSymbolLookup<TUnit>()
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, System.IEquatable<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry.GetSymbolLookup_TUnit_().TUnit'></a>

`TUnit`

The unit of measure type.

#### Returns
[System.Linq.ILookup&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2')[TUnit](UnitRegistry.GetSymbolLookup_TUnit_().md#Jcd.Units.UnitRegistry.GetSymbolLookup_TUnit_().TUnit 'Jcd.Units.UnitRegistry.GetSymbolLookup<TUnit>().TUnit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2')  
A name based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type.