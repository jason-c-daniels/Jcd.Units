#### [Jcd.Units](index.md 'index')

### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection').[GlobalUnitSelectionStrategy](GlobalUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy')

## GlobalUnitSelectionStrategy.ForComparison Property

The globally registered Unit of Measure selection strategy used for comparison operators.
Operands will be compared in the units selected by this unit selection strategy.
By default this is the [SelectLargerUnit](SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation.

```csharp
public static Jcd.Units.UnitSelection.IUnitSelectionStrategy ForComparison { get; set; }
```

#### Property Value

[IUnitSelectionStrategy](IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

### Remarks

NOTES:

1. Before changing this consider if this will impact the DoubleComparers you have registered (either in
   [GlobalDoubleComparisonStrategy](GlobalDoubleComparisonStrategy.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy')'s `Quantity` property, or instance level registrations.
   (i.e. if the operands are converted to a unit with greater or fewer digits after the decimal point, your comparisons
   may not return the expected results. Always do trial runs first to ensure the expected behavior.)
2. This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it
   outside of your application's startup code.