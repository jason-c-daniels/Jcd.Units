#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection 'Jcd.Units.UnitSelection')

## SelectLargerUnit Class

Selects the larger of two units of measure.

```csharp
public sealed class SelectLargerUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectLargerUnit

Implements [IUnitSelectionStrategy](IUnitSelectionStrategy 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectLargerUnit()](SelectLargerUnit.SelectLargerUnit() 'Jcd.Units.UnitSelection.SelectLargerUnit.SelectLargerUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](SelectLargerUnit.Instance 'Jcd.Units.UnitSelection.SelectLargerUnit.Instance') enforcing GC friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](SelectLargerUnit.Instance 'Jcd.Units.UnitSelection.SelectLargerUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](IUnitSelectionStrategy 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](SelectLargerUnit.SelectUnit.JyWp9rRCKTu0Cemzrr4M8w 'Jcd.Units.UnitSelection.SelectLargerUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the larger of two units of measure. |
