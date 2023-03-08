#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure(string, string, TUnit, double, double, IValueComparer<double>) Constructor

Constructs a unit of measure using another [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>') as a base.

```csharp
protected UnitOfMeasure(string name, string symbol, TUnit? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](Jcd.Units.UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [TUnit](Jcd.Units.UnitOfMeasure_TUnit_.md#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')

The unit to use as a base

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).md#Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, TUnit, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).md#Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, TUnit, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](Jcd.Units.IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.