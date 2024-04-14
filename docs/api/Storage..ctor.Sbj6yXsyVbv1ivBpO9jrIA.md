#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes 'Jcd.Units.UnitTypes').[Storage](Storage 'Jcd.Units.UnitTypes.Storage')

## Storage(string, string, Storage, double, double, IValueComparer<double>, string) Constructor

Constructs a unit measuring a specified [Storage](Storage 'Jcd.Units.UnitTypes.Storage') using another [Storage](Storage 'Jcd.Units.UnitTypes.Storage') as a reference.

```csharp
public Storage(string name, string symbol, Jcd.Units.UnitTypes.Storage? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Storage](Storage 'Jcd.Units.UnitTypes.Storage')

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [Storage](Storage 'Jcd.Units.UnitTypes.Storage')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Storage..ctor.Sbj6yXsyVbv1ivBpO9jrIA#Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Storage.Storage(string, string, Jcd.Units.UnitTypes.Storage, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Storage..ctor.Sbj6yXsyVbv1ivBpO9jrIA#Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Storage.Storage(string, string, Jcd.Units.UnitTypes.Storage, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitTypes.Storage.Storage(string,string,Jcd.Units.UnitTypes.Storage,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system the unit of measure belongs to.