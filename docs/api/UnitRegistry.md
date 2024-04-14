#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## UnitRegistry Class

Provides global unit of measure registration and discovery.

```csharp
public class UnitRegistry
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnitRegistry

| Fields                                                              |                                  |
|:--------------------------------------------------------------------|:---------------------------------|
| [Default](UnitRegistry.Default.md 'Jcd.Units.UnitRegistry.Default') | The global registration service. |

| Methods                                                                                                                                                           |                                                                                                                                                                           |
|:------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [Autoregister&lt;TUnit&gt;()](UnitRegistry.Autoregister_TUnit_().md 'Jcd.Units.UnitRegistry.Autoregister<TUnit>()')                                               | Searches all loaded assemblies and registers matching unit types from fields and/or properties.                                                                           |
| [AutoregisterAllUnits()](UnitRegistry.AutoregisterAllUnits().md 'Jcd.Units.UnitRegistry.AutoregisterAllUnits()')                                                  | Searches all loaded assemblies and registers all unit of measure types from fields and/or properties.                                                                     |
| [AutoregisterAllUnitsFrom(Assembly)](UnitRegistry.AutoregisterAllUnitsFrom.sAT8RZzG2YAAShBqQAOL2g.md 'Jcd.Units.UnitRegistry.AutoregisterAllUnitsFrom(Assembly)') | Searches all loaded assemblies and registers all unit of measure types from fields and/or properties.                                                                     |
| [AutoregisterFrom&lt;TUnit&gt;(Assembly)](UnitRegistry.AutoregisterFrom.tEZifYkAdBssgxMZCOxgog.md 'Jcd.Units.UnitRegistry.AutoregisterFrom<TUnit>(Assembly)')     | Searches all loaded assemblies and registers matching unit types from fields and/or properties.                                                                           |
| [GetNameLookup&lt;TUnit&gt;()](UnitRegistry.GetNameLookup_TUnit_().md 'Jcd.Units.UnitRegistry.GetNameLookup<TUnit>()')                                            | Gets a name based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type.   |
| [GetSymbolLookup&lt;TUnit&gt;()](UnitRegistry.GetSymbolLookup_TUnit_().md 'Jcd.Units.UnitRegistry.GetSymbolLookup<TUnit>()')                                      | Gets a symbol based [System.Linq.ILookup&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.ILookup-2 'System.Linq.ILookup`2') for the requested unit type. |
| [Register&lt;TUnit&gt;(TUnit)](UnitRegistry.Register.Er5Wb/24Hxdd+T6XhrxW7Q.md 'Jcd.Units.UnitRegistry.Register<TUnit>(TUnit)')                                   | Registers a unit of measure with the global registry.                                                                                                                     |
