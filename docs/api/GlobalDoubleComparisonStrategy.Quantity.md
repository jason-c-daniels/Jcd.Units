#### [Jcd.Units](index 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison 'Jcd.Units.DoubleComparison').[GlobalDoubleComparisonStrategy](GlobalDoubleComparisonStrategy 'Jcd.Units.DoubleComparison.GlobalDoubleComparisonStrategy')

## GlobalDoubleComparisonStrategy.Quantity Property

The registered double comparer used by Quantities, by default.

```csharp
public static Jcd.Units.IValueComparer<double>? Quantity { get; set; }
```

#### Property Value
[Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

### Remarks
This is not a thread safe property. Synchronize your code around setting/getting this if you plan on setting it
outside of your application's startup code.