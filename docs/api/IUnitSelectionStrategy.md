#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection 'Jcd.Units.UnitSelection')

## IUnitSelectionStrategy Interface

Defines the interface for selecting between two units of measure.

```csharp
public interface IUnitSelectionStrategy
```

Derived
&#8627; [SelectFundamentalUnit](SelectFundamentalUnit 'Jcd.Units.UnitSelection.SelectFundamentalUnit')
&#8627; [SelectLargerUnit](SelectLargerUnit 'Jcd.Units.UnitSelection.SelectLargerUnit')
&#8627; [SelectLeftUnit](SelectLeftUnit 'Jcd.Units.UnitSelection.SelectLeftUnit')
&#8627; [SelectRightUnit](SelectRightUnit 'Jcd.Units.UnitSelection.SelectRightUnit')
&#8627; [SelectSmallerUnit](SelectSmallerUnit 'Jcd.Units.UnitSelection.SelectSmallerUnit')

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](IUnitSelectionStrategy.SelectUnit.Klb+x/umqLvPEeeX9EMM+w 'Jcd.Units.UnitSelection.IUnitSelectionStrategy.SelectUnit<TUnit>(TUnit, TUnit)') | Given two units of measure, return the one indicated by the strategy. |
