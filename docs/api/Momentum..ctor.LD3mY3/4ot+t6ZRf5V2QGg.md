#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes 'Jcd.Units.UnitTypes').[Momentum](Momentum 'Jcd.Units.UnitTypes.Momentum')

## Momentum(string, string, Momentum, double, double, IValueComparer<double>, string) Constructor

Constructs a unit measuring a specified [Momentum](Momentum 'Jcd.Units.UnitTypes.Momentum') using another [Momentum](Momentum 'Jcd.Units.UnitTypes.Momentum') as a
reference.

```csharp
public Momentum(string name, string symbol, Jcd.Units.UnitTypes.Momentum? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Momentum](Momentum 'Jcd.Units.UnitTypes.Momentum')

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [Momentum](Momentum 'Jcd.Units.UnitTypes.Momentum')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Momentum..ctor.LD3mY3/4ot+t6ZRf5V2QGg#Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Momentum.Momentum(string, string, Jcd.Units.UnitTypes.Momentum, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Momentum..ctor.LD3mY3/4ot+t6ZRf5V2QGg#Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Momentum.Momentum(string, string, Jcd.Units.UnitTypes.Momentum, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system the unit of measure belongs to.