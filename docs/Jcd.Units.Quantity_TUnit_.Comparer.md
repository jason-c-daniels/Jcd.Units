#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity<TUnit>.Comparer Property

The [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons: where `T` is a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double').

```csharp
public Jcd.Units.IValueComparer<double>? Comparer { get; }
```

#### Property Value
[Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

### Remarks
If not assigned during initialization, this returns [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')  
type specific comparison (e.g. Temperatures) or and the globally configured comparer.