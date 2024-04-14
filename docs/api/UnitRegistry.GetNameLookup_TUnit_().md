#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.GetNameLookup<TUnit>() Method

Gets a name based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type.

```csharp
public ILookup<string,TUnit> GetNameLookup<TUnit>()
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, IEquatable<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry.GetNameLookup_TUnit_().TUnit'></a>

`TUnit`

The unit of measure type.

#### Returns
[System.Linq.ILookup](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup 'System.Linq.ILookup')
A name based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type.