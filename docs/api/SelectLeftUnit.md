#### [Jcd.Units](index.md 'index')

### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## SelectLeftUnit Class

Selects the left hand side of two units of measure.

```csharp
public sealed class SelectLeftUnit :
Jcd.Units.UnitSelection.IUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SelectLeftUnit

Implements [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

| Constructors                                                                                                     |                                                                                                                                                                                                |
|:-----------------------------------------------------------------------------------------------------------------|:-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [SelectLeftUnit()](SelectLeftUnit.SelectLeftUnit().md 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectLeftUnit()') | Prevent others from instantiating it because I'm mean. (Forces the use of [Instance](SelectLeftUnit.Instance.md 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') enforcing GC friendliness.) |

| Fields                                                                                   |                                                                                                                                               |
|:-----------------------------------------------------------------------------------------|:----------------------------------------------------------------------------------------------------------------------------------------------|
| [Instance](SelectLeftUnit.Instance.md 'Jcd.Units.UnitSelection.SelectLeftUnit.Instance') | The default (and only) instance of this [IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy'). |

| Methods                                                                                                                                                               |                                                     |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------|
| [SelectUnit&lt;TUnit&gt;(TUnit, TUnit)](SelectLeftUnit.SelectUnit.JnpgM+OuRKOhEFHWslZFag.md 'Jcd.Units.UnitSelection.SelectLeftUnit.SelectUnit<TUnit>(TUnit, TUnit)') | Selects the left hand side of two units of measure. |
