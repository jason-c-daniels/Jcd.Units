#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure<TUnit>.Comparer Property

The [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons: where `T` is a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public Jcd.Units.IValueComparer<double>? Comparer { get; set; }
```

#### Property Value
[Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

### Remarks
If not assigned during initialization, this returns [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')
type specific comparison (e.g. Temperatures) or and the globally configured comparer.