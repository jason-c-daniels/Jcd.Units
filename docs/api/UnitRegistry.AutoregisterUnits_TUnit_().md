#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.AutoregisterUnits<TUnit>() Method

Searches all loaded assemblies and registers matching unit types from fields and/or properties.

```csharp
public void AutoregisterUnits<TUnit>()
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, IEquatable<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry.AutoregisterUnits_TUnit_().TUnit'></a>

`TUnit`

The type of unit of measure to discover and register.