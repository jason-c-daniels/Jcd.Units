#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.AutoregisterFrom<TUnit>(Assembly) Method

Searches all loaded assemblies and registers matching unit types from fields and/or properties.

```csharp
public void AutoregisterFrom<TUnit>(Assembly assembly)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, IEquatable<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry.AutoregisterFrom_TUnit_(Assembly).TUnit'></a>

`TUnit`

The type of unit of measure to discover and register.
#### Parameters

<a name='Jcd.Units.UnitRegistry.AutoregisterFrom_TUnit_(Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')