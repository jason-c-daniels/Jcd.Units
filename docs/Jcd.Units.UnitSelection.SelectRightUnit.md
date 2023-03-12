#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectRightUnit Class

Selects the right hand side of two units of measure.

```csharp
public sealed class SelectRightUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectRightUnit

Implements [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectRightUnit()](Jcd.Units.UnitSelection.SelectRightUnit.SelectRightUnit().md 'Jcd.Units.UnitSelection.SelectRightUnit.SelectRightUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](Jcd.Units.UnitSelection.SelectRightUnit.Instance.md 'Jcd.Units.UnitSelection.SelectRightUnit.Instance') enforcing GC<br/>friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](Jcd.Units.UnitSelection.SelectRightUnit.Instance.md 'Jcd.Units.UnitSelection.SelectRightUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](Jcd.Units.UnitSelection.SelectRightUnit.SelectUnit_TUnit_(TUnit,TUnit).md 'Jcd.Units.UnitSelection.SelectRightUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the right hand side of two units of measure. |
