#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection')

## GlobalUnitSelectionStrategy Class

Globally registered

```csharp
public static class GlobalUnitSelectionStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GlobalUnitSelectionStrategy

| Properties | |
| :--- | :--- |
| [ForArithmetic](Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForArithmetic.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForArithmetic') | The globally registered Unit of Measure selection strategy used for arithmetic operators.<br/>Results will be returned in the unit of measure selected by this unit selection strategy.<br/>By default this is the [SelectLargerUnit](Jcd.Units.UnitSelection.SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation. |
| [ForComparison](Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForComparison.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.ForComparison') | The globally registered Unit of Measure selection strategy used for comparison operators.<br/>Operands will be compared in the units selected by this unit selection strategy.<br/>By default this is the [SelectLargerUnit](Jcd.Units.UnitSelection.SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation. |
