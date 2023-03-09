#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectSmallerUnit Class

Selects the smaller of two units of measure.

```csharp
public sealed class SelectSmallerUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectSmallerUnit

Implements [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectSmallerUnit()](Jcd.Units.UnitSelection.SelectSmallerUnit.SelectSmallerUnit().md 'Jcd.Units.UnitSelection.SelectSmallerUnit.SelectSmallerUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](Jcd.Units.UnitSelection.SelectSmallerUnit.Instance.md 'Jcd.Units.UnitSelection.SelectSmallerUnit.Instance') enforcing GC friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](Jcd.Units.UnitSelection.SelectSmallerUnit.Instance.md 'Jcd.Units.UnitSelection.SelectSmallerUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit_TUnit_(TUnit,TUnit).md 'Jcd.Units.UnitSelection.SelectSmallerUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the smaller of two units of measure. |
