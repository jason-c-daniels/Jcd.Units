#### [Jcd.Units](index.md 'index')
### [Jcd.Units.DoubleComparisons](Jcd.Units.DoubleComparisons.md 'Jcd.Units.DoubleComparisons').[GlobalDoubleComparisonStrategy](Jcd.Units.DoubleComparisons.GlobalDoubleComparisonStrategy.md 'Jcd.Units.DoubleComparisons.GlobalDoubleComparisonStrategy')

## GlobalDoubleComparisonStrategy.UnitOfMeasure Property

The globally registered double comparer used for comparing [UnitOfMeasure](Jcd.Units.DoubleComparisons.GlobalDoubleComparisonStrategy.UnitOfMeasure.md 'Jcd.Units.DoubleComparisons.GlobalDoubleComparisonStrategy.UnitOfMeasure') instances. It's unlikely that you will actually need to set this to anything other than the default (bitwise comparison)

```csharp
public static Jcd.Units.IValueComparer<double>? UnitOfMeasure { get; set; }
```

#### Property Value
[Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

### Remarks
This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it outside of your application's startup code.