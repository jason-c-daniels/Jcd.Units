#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection').[SelectFundamentalUnit](Jcd.Units.UnitSelection.SelectFundamentalUnit.md 'Jcd.Units.UnitSelection.SelectFundamentalUnit')

## SelectFundamentalUnit.SelectUnit<TUnit>(TUnit, TUnit) Method

Selects the fundamental unit of measure. This should be the same for both so unit1 is used.

```csharp
public TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
    where TUnit : Jcd.Units.IUnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit'></a>

`TUnit`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).left'></a>

`left` [TUnit](Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).md#Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The first unit to consider

<a name='Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).right'></a>

`right` [TUnit](Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).md#Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The second unit to consider.

Implements [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit_TUnit_(TUnit,TUnit).md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit)')

#### Returns
[TUnit](Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).md#Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')  
The larger unit of measure.