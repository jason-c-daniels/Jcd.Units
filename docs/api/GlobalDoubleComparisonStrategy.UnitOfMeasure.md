#### [Jcd.Units](index 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison 'Jcd.Units.DoubleComparison').[GlobalDoubleComparisonStrategy](GlobalDoubleComparisonStrategy 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy')

## GlobalDoubleComparisonStrategy.UnitOfMeasure Property

The globally registered double comparer used for comparing [UnitOfMeasure](GlobalDoubleComparisonStrategy.UnitOfMeasure 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy.UnitOfMeasure') instances. It's unlikely
that you will actually need to set this to anything other than the default (bitwise comparison)

```csharp
public static Jcd.Units.IValueComparer<double>? UnitOfMeasure { get; set; }
```

#### Property Value
[Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

### Remarks
This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it
outside of your application's startup code.