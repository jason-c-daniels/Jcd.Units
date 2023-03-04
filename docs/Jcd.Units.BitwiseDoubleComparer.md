#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## BitwiseDoubleComparer Class

Performs standard, compiler provided, comparison operations against two doubles.

```csharp
public class BitwiseDoubleComparer :
Jcd.Units.IValueComparer<double>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Collections.Generic.IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer 'System.Collections.Generic.IComparer') &#129106; [System.Collections.Generic.IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer') &#129106; BitwiseDoubleComparer

Implements [Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

| Fields | |
| :--- | :--- |
| [Standard](Jcd.Units.BitwiseDoubleComparer.Standard.md 'Jcd.Units.BitwiseDoubleComparer.Standard') | The default instance. Use this instead of constantly creating new ones. It's easier<br/>on the garbage collector. |

| Methods | |
| :--- | :--- |
| [Compare(double, double)](Jcd.Units.BitwiseDoubleComparer.Compare(double,double).md 'Jcd.Units.BitwiseDoubleComparer.Compare(double, double)') | Compares two doubles by the compiler provided default. This carries with it all the concerns<br/>of doing raw double comparisons. This is provided as a default mechanism to kickstart<br/>operations. You should really implement and use your own comparer as per your application's needs. |
| [Equals(double, double)](Jcd.Units.BitwiseDoubleComparer.Equals(double,double).md 'Jcd.Units.BitwiseDoubleComparer.Equals(double, double)') | Compares two doubles for equality. |
