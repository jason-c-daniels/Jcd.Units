#### [Jcd.Units](index.md 'index')

### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection').[SelectLeftUnit](SelectLeftUnit.md 'Jcd.Units.UnitSelection.SelectLeftUnit')

## SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit) Method

Selects the left hand side of two units of measure.

```csharp
public TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
    where TUnit : Jcd.Units.IUnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit'></a>

`TUnit`

The unit of measure type.

#### Parameters

<a name='Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).left'></a>

`left` [TUnit](SelectLeftUnit.SelectUnit.JnpgM+OuRKOhEFHWslZFag.md#Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The first unit to consider

<a name='Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).right'></a>

`right` [TUnit](SelectLeftUnit.SelectUnit.JnpgM+OuRKOhEFHWslZFag.md#Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The second unit to consider.

Implements [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit)')

#### Returns

[TUnit](SelectLeftUnit.SelectUnit.JnpgM+OuRKOhEFHWslZFag.md#Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')
The larger unit of measure.