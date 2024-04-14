#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure(string, string, TUnit, double, double, IValueComparer<double>, string) Constructor

Constructs a unit of measure using another [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>') as a base.

```csharp
protected UnitOfMeasure(string name, string symbol, TUnit? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [TUnit](UnitOfMeasure_TUnit_#Jcd.Units.UnitOfMeasure_TUnit_.TUnit 'Jcd.Units.UnitOfMeasure<TUnit>.TUnit')

The unit to use as a base

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](UnitOfMeasure_TUnit_..ctor.ppaE236Nm6TcDuxxxVbfFA#Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, TUnit, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](UnitOfMeasure_TUnit_..ctor.ppaE236Nm6TcDuxxxVbfFA#Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitOfMeasure<TUnit>.UnitOfMeasure(string, string, TUnit, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,TUnit,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system of measure the unit belongs to.