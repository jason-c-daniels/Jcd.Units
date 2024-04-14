#### [Jcd.Units](index 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison 'Jcd.Units.DoubleComparison')

## BuiltInRoundingComparer Struct

Rounds two values then compares them using the builtin Round method of [System.Math](https://docs.microsoft.com/en-us/dotnet/api/System.Math 'System.Math')

```csharp
public readonly struct BuiltInRoundingComparer :
Jcd.Units.IValueComparer<double>
```

Implements [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

| Constructors | |
| :--- | :--- |
| [BuiltInRoundingComparer(int, MidpointRounding)](BuiltInRoundingComparer..ctor.tYphWrxAoxUa8qg1tMznVQ 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.BuiltInRoundingComparer(int, MidpointRounding)') | Constructs an instance of [BuiltInRoundingComparer](BuiltInRoundingComparer 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer') from number of decimal places and a rounding method. |

| Fields | |
| :--- | :--- |
| [Default](BuiltInRoundingComparer.Default 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.Default') | An alias for [FifteenDecimalPlaces](BuiltInRoundingComparer.FifteenDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces') |
| [FifteenDecimalPlaces](BuiltInRoundingComparer.FifteenDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FifteenDecimalPlaces') | A 15 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. This is the maximum number of valid . |
| [FiveDecimalPlaces](BuiltInRoundingComparer.FiveDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FiveDecimalPlaces') | A 5 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [FourDecimalPlaces](BuiltInRoundingComparer.FourDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.FourDecimalPlaces') | A 4 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [NineDecimalPlaces](BuiltInRoundingComparer.NineDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.NineDecimalPlaces') | A 9 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [OneDecimalPlace](BuiltInRoundingComparer.OneDecimalPlace 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.OneDecimalPlace') | A 1 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [SixDecimalPlaces](BuiltInRoundingComparer.SixDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.SixDecimalPlaces') | A 6 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [TenDecimalPlaces](BuiltInRoundingComparer.TenDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TenDecimalPlaces') | A 10 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [ThreeDecimalPlaces](BuiltInRoundingComparer.ThreeDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.ThreeDecimalPlaces') | A 3 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [TwoDecimalPlaces](BuiltInRoundingComparer.TwoDecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.TwoDecimalPlaces') | A 2 decimal place rounding comparer, using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |
| [WholeNumber](BuiltInRoundingComparer.WholeNumber 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.WholeNumber') | A Rounds to a whole number using [System.MidpointRounding.ToEven](https://docs.microsoft.com/en-us/dotnet/api/System.MidpointRounding.ToEven 'System.MidpointRounding.ToEven') as the midpoint rounding method. |

| Properties | |
| :--- | :--- |
| [DecimalPlaces](BuiltInRoundingComparer.DecimalPlaces 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.DecimalPlaces') | The number of decimal places to round to. |
| [RoundingMethod](BuiltInRoundingComparer.RoundingMethod 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer.RoundingMethod') | The rounding method to employ. |
