#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectFundamentalUnit Class

Selects the fundamental unit of measure. This should be the same for both so unit1 is used.

```csharp
public sealed class SelectFundamentalUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectFundamentalUnit

Implements [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectFundamentalUnit()](Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectFundamentalUnit().md 'Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectFundamentalUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](Jcd.Units.UnitSelection.SelectFundamentalUnit.Instance.md 'Jcd.Units.UnitSelection.SelectFundamentalUnit.Instance') enforcing GC<br/>friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](Jcd.Units.UnitSelection.SelectFundamentalUnit.Instance.md 'Jcd.Units.UnitSelection.SelectFundamentalUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit_TUnit_(TUnit,TUnit).md 'Jcd.Units.UnitSelection.SelectFundamentalUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the fundamental unit of measure. This should be the same for both so unit1 is used. |
