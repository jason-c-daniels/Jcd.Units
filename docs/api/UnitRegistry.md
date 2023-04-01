#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitRegistry Class

Provides global unit of measure registration and discovery.

```csharp
public class UnitRegistry
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnitRegistry

| Fields | |
| :--- | :--- |
| [Default](UnitRegistry.Default.md 'Jcd.Units.UnitRegistry.Default') | The global registration service. |

| Methods | |
| :--- | :--- |
| [AutoregisterAllUnits()](UnitRegistry.AutoregisterAllUnits().md 'Jcd.Units.UnitRegistry.AutoregisterAllUnits()') | Searches all loaded assemblies and registers all unit of measure types from fields and/or properties. |
| [AutoregisterUnits&lt;TUnit&gt;()](UnitRegistry.AutoregisterUnits_TUnit_().md 'Jcd.Units.UnitRegistry.AutoregisterUnits<TUnit>()') | Searches all loaded assemblies and registers matching unit types from fields and/or properties. |
| [GetNameLookup&lt;TUnit&gt;()](UnitRegistry.GetNameLookup_TUnit_().md 'Jcd.Units.UnitRegistry.GetNameLookup<TUnit>()') | Gets a name based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type. |
| [GetSymbolLookup&lt;TUnit&gt;()](UnitRegistry.GetSymbolLookup_TUnit_().md 'Jcd.Units.UnitRegistry.GetSymbolLookup<TUnit>()') | Gets a symbol based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type. |
| [Register&lt;TUnit&gt;(TUnit)](UnitRegistry.Register.Er5Wb/24Hxdd+T6XhrxW7Q.md 'Jcd.Units.UnitRegistry.Register<TUnit>(TUnit)') | Registers a unit of measure with the global registry. |
