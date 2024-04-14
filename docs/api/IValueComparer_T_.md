#### [Jcd.Units](index.md 'index')

### [Jcd.Units](Jcd.Units.md 'Jcd.Units')

## IValueComparer<T> Interface

Defines a marker interface used to enforce providing both relational (CompareTo) and equality comparisons on a given
type.

```csharp
public interface IValueComparer<in T>
```

#### Type parameters

<a name='Jcd.Units.IValueComparer_T_.T'></a>

`T`

The datatype being compared

Derived
&#8627; [BitwiseDoubleComparer](BitwiseDoubleComparer.md 'Jcd.Units.DoubleComparison.BitwiseDoubleComparer')
&#8627; [BuiltInRoundingComparer](BuiltInRoundingComparer.md 'Jcd.Units.DoubleComparison.BuiltInRoundingComparer')

### Remarks

This type is used to provide stable hash codes (i.e. hash codes that are identical for values
that the implementation compares as equivalent.) and comparison implementations to provide
application defined comparison operations. It's most useful for [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'), [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') and
custom data types.