#### [Jcd.Units](index.md 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison.md 'Jcd.Units.DoubleComparison')

## GlobalDoubleComparisonStrategy Class

Provides global fallback double comparison strategies used by [Quantity](GlobalDoubleComparisonStrategy.Quantity.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.Quantity') and
[UnitOfMeasure](GlobalDoubleComparisonStrategy.UnitOfMeasure.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.UnitOfMeasure').

```csharp
public static class GlobalDoubleComparisonStrategy
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GlobalDoubleComparisonStrategy

### Remarks
For performance reasons the properties within are not thread safe.
As well it's a bad practice to set these frequently in separate threads.
Your comparison results may be very unstable, even with proper thread synchronization.

| Fields | |
| :--- | :--- |
| [Default](GlobalDoubleComparisonStrategy.Default.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.Default') | The default (bitwise) double comparer. You really should use something else. |

| Properties | |
| :--- | :--- |
| [Quantity](GlobalDoubleComparisonStrategy.Quantity.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.Quantity') | The registered double comparer used by Quantities, by default. |
| [UnitOfMeasure](GlobalDoubleComparisonStrategy.UnitOfMeasure.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.UnitOfMeasure') | The globally registered double comparer used for comparing [UnitOfMeasure](GlobalDoubleComparisonStrategy.UnitOfMeasure.md 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.UnitOfMeasure') instances. It's unlikely that you will actually need to set this to anything other than the default (bitwise comparison) |
