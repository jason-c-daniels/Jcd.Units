#### [Jcd.Units](index 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison 'Jcd.Units.DoubleComparison')

## BitwiseDoubleComparer Struct

Performs standard, compiler provided, comparison operations against two doubles.

```csharp
public readonly struct BitwiseDoubleComparer :
Jcd.Units.IValueComparer<double>
```

Implements [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

| Fields | |
| :--- | :--- |
| [Instance](BitwiseDoubleComparer.Instance 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Instance') | The default instance. Use this instead of constantly creating new ones. It's easier on the garbage collector. |

| Methods | |
| :--- | :--- |
| [Compare(double, double)](BitwiseDoubleComparer.Compare.m5n3zbf+p9s3+VUE389Rhg 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double)') | Compares two doubles by the compiler provided default. This carries with it all the concerns of doing raw double comparisons. This is provided as a default mechanism to kickstart operations. You should really implement and use your own comparer as per your application's needs. |
| [Equals(double, double)](BitwiseDoubleComparer.Equals.mEmItaKhugxWaP+F6aPW8A 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Equals(double, double)') | Compares two doubles for equality. |
