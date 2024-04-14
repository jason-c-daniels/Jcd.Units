#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## IUnitSelectionStrategy Interface

Defines the interface for selecting between two units of measure.

```csharp
public interface IUnitSelectionStrategy
```

Derived
&#8627; [SelectFundamentalUnit](SelectFundamentalUnit.md 'Jcd.Units.UnitSelection.SelectFundamentalUnit')
&#8627; [SelectLargerUnit](SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit')
&#8627; [SelectLeftUnit](SelectLeftUnit.md 'Jcd.Units.UnitSelection.SelectLeftUnit')
&#8627; [SelectRightUnit](SelectRightUnit.md 'Jcd.Units.UnitSelection.SelectRightUnit')
&#8627; [SelectSmallerUnit](SelectSmallerUnit.md 'Jcd.Units.UnitSelection.SelectSmallerUnit')

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit)') | Given two units of measure, return the one indicated by the strategy. |
