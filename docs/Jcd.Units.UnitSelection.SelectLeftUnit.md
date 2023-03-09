#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectLeftUnit Class

Selects the left hand side of two units of measure.

```csharp
public sealed class SelectLeftUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectLeftUnit

Implements [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectLeftUnit()](Jcd.Units.UnitSelection.SelectLeftUnit.SelectLeftUnit().md 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectLeftUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](Jcd.Units.UnitSelection.SelectLeftUnit.Instance.md 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') enforcing GC friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](Jcd.Units.UnitSelection.SelectLeftUnit.Instance.md 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit_TUnit_(TUnit,TUnit).md 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the left hand side of two units of measure. |
