#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.Autoregister<TUnit>() Method

Searches all loaded assemblies and registers matching unit types from fields and/or properties.

```csharp
public void Autoregister<TUnit>()
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, System.IEquatable<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitRegistry.Autoregister_TUnit_().TUnit'></a>

`TUnit`

The type of unit of measure to discover and register.