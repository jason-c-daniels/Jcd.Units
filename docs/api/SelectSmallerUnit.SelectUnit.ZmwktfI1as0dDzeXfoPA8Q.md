#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection 'Jcd.Units.UnitSelection').[SelectSmallerUnit](SelectSmallerUnit 'Jcd.Units.UnitSelection.SelectSmallerUnit')

## SelectSmallerUnit.SelectUnit<TUnit>(TUnit, TUnit) Method

Selects the smaller of two units of measure.

```csharp
public TUnit SelectUnit<TUnit>(TUnit left, TUnit right)
    where TUnit : Jcd.Units.IUnitOfMeasure<TUnit>;
```
#### Type parameters

<a name='Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit'></a>

`TUnit`

The unit of measure type.
#### Parameters

<a name='Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).left'></a>

`left` [TUnit](SelectSmallerUnit.SelectUnit.ZmwktfI1as0dDzeXfoPA8Q#Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The first unit to consider

<a name='Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).right'></a>

`right` [TUnit](SelectSmallerUnit.SelectUnit.ZmwktfI1as0dDzeXfoPA8Q#Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')

The second unit to consider.

Implements [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit)')

#### Returns
[TUnit](SelectSmallerUnit.SelectUnit.ZmwktfI1as0dDzeXfoPA8Q#Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).TUnit 'Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit<TUnit>(TUnit, TUnit).TUnit')
The larger unit of measure.