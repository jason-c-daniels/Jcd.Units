#### [Jcd.Units](index.md 'index')

### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection').[IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

## IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit) Method

Given two units of measure, return the one indicated by the strategy.

```csharp
TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
    where TUnit : Jcd.Units.IUnitOfMeasure<TUnit>;
```

#### Type parameters

<a name='Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).TUnit'></a>

`TUnit`

The concrete [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') type.

#### Parameters

<a name='Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).left'></a>

`left` [TUnit](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w.md#Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The first unit of measure to consider.

<a name='Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).right'></a>

`right` [TUnit](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w.md#Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The second unit of measure to consider.

#### Returns

[TUnit](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w.md#Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit).TUnit')
The unit selected