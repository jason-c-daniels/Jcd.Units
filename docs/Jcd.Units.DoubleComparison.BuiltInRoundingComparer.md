#### [Jcd.Units](index.md 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison.md 'Jcd.Units.DoubleComparison')

## BuiltInRoundingComparer Struct

Rounds two values then compares them using the builtin Round method of [System.Math](https://docs.microsoft.com/en-us/dotnet/api/System.Math 'System.Math')

```csharp
public readonly struct BuiltInRoundingComparer :
Jcd.Units.IValueComparer<double>
```

Implements [Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

| Constructors | |
| :--- | :--- |
| [BuiltInRoundingComparer(int, MidpointRounding)](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.BuiltInRoundingComparer(int,MidpointRounding).md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.BuiltInRoundingComparer(int, MidpointRounding)') | Constructs an instance of [BuiltInRoundingComparer](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer') from number of decimal places and a rounding method. |

| Fields | |
| :--- | :--- |
| [Default](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.Default.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.Default') | An alias for [FifteenDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces') |
| [FifteenDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces') | A 15 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method.<br/>This is the maximum number of valid . |
| [FiveDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FiveDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FiveDecimalPlaces') | A 5 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [FourDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FourDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FourDecimalPlaces') | A 4 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [NineDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.NineDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.NineDecimalPlaces') | A 9 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [OneDecimalPlace](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.OneDecimalPlace.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.OneDecimalPlace') | A 1 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [SixDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.SixDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.SixDecimalPlaces') | A 6 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [TenDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TenDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TenDecimalPlaces') | A 10 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [ThreeDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.ThreeDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.ThreeDecimalPlaces') | A 3 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [TwoDecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TwoDecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TwoDecimalPlaces') | A 2 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [WholeNumber](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.WholeNumber.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.WholeNumber') | A Rounds to a whole number using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |

| Properties | |
| :--- | :--- |
| [DecimalPlaces](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.DecimalPlaces.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.DecimalPlaces') | The number of decimal places to round to. |
| [RoundingMethod](Jcd.Units.DoubleComparison.BuiltInRoundingComparer.RoundingMethod.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.RoundingMethod') | The rounding method to employ. |
