#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[Quantity&lt;TUnit&gt;](Jcd.Units.Quantity_TUnit_.md 'Jcd.Units.Quantity<TUnit>')

## Quantity(double, TUnit, IValueComparer<double>) Constructor

Represents a quantity with an associated unit of measure.

```csharp
public Quantity(double rawValue, TUnit unit, Jcd.Units.IValueComparer<double>? baseUnitComparer=null);
```
#### Parameters

<a name='Jcd.Units.Quantity_TUnit_.Quantity(double,TUnit,Jcd.Units.IValueComparer_double_).rawValue'></a>

`rawValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The numeric portion, without associated unit of measure

<a name='Jcd.Units.Quantity_TUnit_.Quantity(double,TUnit,Jcd.Units.IValueComparer_double_).unit'></a>

`unit` [TUnit](Jcd.Units.Quantity_TUnit_.md#Jcd.Units.Quantity_TUnit_.TUnit 'Jcd.Units.Quantity<TUnit>.TUnit')

The unit of measure.

<a name='Jcd.Units.Quantity_TUnit_.Quantity(double,TUnit,Jcd.Units.IValueComparer_double_).baseUnitComparer'></a>

`baseUnitComparer` [Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

Compares two doubles represented as doubles in the base unit of measure.