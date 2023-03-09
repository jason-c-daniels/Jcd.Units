#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitSelection](Jcd.Units.UnitSelection.md 'Jcd.Units.UnitSelection').[GlobalUnitSelectionStrategy](Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.GlobalUnitSelectionStrategy')

## GlobalUnitSelectionStrategy.ForArithmetic Property

The globally registered Unit of Measure selection strategy used for arithmetic operators.  
Results will be returned in the unit of measure selected by this unit selection strategy.  
By default this is the [SelectLargerUnit](Jcd.Units.UnitSelection.SelectLargerUnit.md 'Jcd.Units.UnitSelection.SelectLargerUnit') implementation.

```csharp
public static Jcd.Units.UnitSelection.IUnitSelectionStrategy ForArithmetic { get; set; }
```

#### Property Value
[IUnitSelectionStrategy](Jcd.Units.UnitSelection.IUnitSelectionStrategy.md 'Jcd.Units.UnitSelection.IUnitSelectionStrategy')

### Remarks
This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it outside of your application's startup code.