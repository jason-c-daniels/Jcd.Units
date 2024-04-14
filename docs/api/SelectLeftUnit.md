#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection 'Jcd.Units.UnitSelection')

## SelectLeftUnit Class

Selects the left hand side of two units of measure.

```csharp
public sealed class SelectLeftUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectLeftUnit

Implements [IUnitSelectionStrategy](IUnitSelectionStrategy 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors | |
| :--- | :--- |
| [SelectLeftUnit()](SelectLeftUnit.SelectLeftUnit() 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectLeftUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](SelectLeftUnit.Instance 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') enforcing GC friendliness.) |

| Fields | |
| :--- | :--- |
| [Instance](SelectLeftUnit.Instance 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](IUnitSelectionStrategy 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods | |
| :--- | :--- |
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](SelectLeftUnit.SelectUnit.JnpgM+OuRKOhEFHWslZFag 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the left hand side of two units of measure. |
