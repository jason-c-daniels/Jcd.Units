#### [Jcd.Units](index.md 'index')
### [Jcd.Units.DoubleComparison](Jcd.Units.DoubleComparison.md 'Jcd.Units.DoubleComparison')

## BitwiseDoubleComparer Struct

Performs standard, compiler provided, comparison operations against two doubles.

```csharp
public struct BitwiseDoubleComparer :
Jcd.Units.IValueComparer<double>
```

Implements [Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

| Fields | |
| :--- | :--- |
| [Default](Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Default.md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Default') | The default instance. Use this instead of constantly creating new ones. It's easier<br/>on the garbage collector. |

| Methods | |
| :--- | :--- |
| [Compare(double, double)](Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double,double).md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Compare(double, double)') | Compares two doubles by the compiler provided default. This carries with it all the concerns<br/>of doing raw double comparisons. This is provided as a default mechanism to kickstart<br/>operations. You should really implement and use your own comparer as per your application's needs. |
| [Equals(double, double)](Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Equals(double,double).md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer.Equals(double, double)') | Compares two doubles for equality. |
