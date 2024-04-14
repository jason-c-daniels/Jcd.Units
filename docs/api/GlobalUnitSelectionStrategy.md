#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## GlobalUnitSelectionStrategy Class

Globally registered

```csharp
public static class GlobalUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GlobalUnitSelectionStrategy

| Fields | |
| :--- | :--- |
| [Default](GlobalUnitSelectionStrategy.Default.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.Default') | The default strategy used in selecting a unit of measure for comparison and/or arithmetic operations. |

| Properties | |
| :--- | :--- |
| [ForArithmetic](GlobalUnitSelectionStrategy.ForArithmetic.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForArithmetic') | The globally registered Unit of Measure selection strategy used for arithmetic operators. Results will be returned in the unit of measure selected by this unit selection strategy. By default this is the [SelectLargerUnit](SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation. |
| [ForComparison](GlobalUnitSelectionStrategy.ForComparison.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForComparison') | The globally registered Unit of Measure selection strategy used for comparison operators. Operands will be compared in the units selected by this unit selection strategy. By default this is the [SelectLargerUnit](SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation. |
