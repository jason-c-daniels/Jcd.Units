#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitRegistry](UnitRegistry.md 'Jcd.Units.UnitRegistry')

## UnitRegistry.Register<TUnit>(TUnit) Method

Registers a unit of measure with the global registry.

```csharp
public void Register<TUnit>(TUnit unit)
    where TUnit : Jcd.Units.UnitOfMeasure<TUnit>, IEquatable<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.UnitRegistry.Register_TUnit_(TUnit).TUnit'></a>

`TUnit`

The type of unit of measure.

#### Parameters

<a name='Jcd.Units.UnitRegistry.Register_TUnit_(TUnit).unit'></a>

`unit` [TUnit](UnitRegistry.Register.Er5Wb/24Hxdd+T6XhrxW7Q.md#Jcd.Units.UnitRegistry.Register_TUnit_(TUnit).TUnit 'Jcd.Units.UnitRegistry.Register<TUnit>(TUnit).TUnit')

The unit of measure.