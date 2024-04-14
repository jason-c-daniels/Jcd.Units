#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectRightUnit Class

Selects the right hand side of two units of measure.

```csharp
public sealed class SelectRightUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectRightUnit

Implements [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectRightUnit()](SelectRightUnit.SelectRightUnit().md 'Jcd.Units.UnitSelection.SelectRightUnit.SelectRightUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](SelectRightUnit.Instance.md 'Jcd.Units.UnitSelection.SelectRightUnit.Instance') enforcing GC friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](SelectRightUnit.Instance.md 'Jcd.Units.UnitSelection.SelectRightUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](SelectRightUnit.SelectUnit.1nv5Ez+gThIJcHMiaOF/4g.md 'Jcd.Units.UnitSelection.SelectRightUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the right hand side of two units of measure. |
