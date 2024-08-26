#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IValueComparer<T> Interface

Defines a marker interface used to enforce providing both relational (CompareTo) and equality comparisons on a given  
type.

```csharp
public interface IValueComparer<in T> :
System.Collections.Generic.IComparer<T>,
System.Collections.Generic.IEqualityComparer<T>
```
#### Type parameters

<a name='Jcd.Units.IValueComparer_T_.T'></a>

`T`

The datatype being compared

Derived  
&#8627; [BitwiseDoubleComparer](BitwiseDoubleComparer.md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer')  
&#8627; [BuiltInRoundingComparer](BuiltInRoundingComparer.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer')

Implements [System.Collections.Generic.IComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1')[T](IValueComparer_T_.md#Jcd.Units.IValueComparer_T_.T 'Jcd.Units.IValueComparer<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1 'System.Collections.Generic.IComparer`1'), [System.Collections.Generic.IEqualityComparer&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')[T](IValueComparer_T_.md#Jcd.Units.IValueComparer_T_.T 'Jcd.Units.IValueComparer<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1 'System.Collections.Generic.IEqualityComparer`1')

### Remarks
This type is used to provide stable hash codes (i.e. hash codes that are identical for values  
that the implementation compares as equivalent.) and comparison implementations to provide  
application defined comparison operations. It's most useful for [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') and  
custom data types.