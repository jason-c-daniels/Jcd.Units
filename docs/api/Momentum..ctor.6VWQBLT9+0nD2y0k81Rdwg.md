#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum')

## Momentum(string, string, Momentum, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum') using another [Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum') as a reference.

```csharp
public Momentum(string name, string symbol, Jcd.Units.UnitTypes.Momentum? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum')

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [Momentum](Momentum.md 'Jcd.Units.UnitTypes.Momentum')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Momentum..ctor.6VWQBLT9+0nD2y0k81Rdwg.md#Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Momentum.Momentum(string, string, Jcd.Units.UnitTypes.Momentum, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Momentum..ctor.6VWQBLT9+0nD2y0k81Rdwg.md#Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Momentum.Momentum(string, string, Jcd.Units.UnitTypes.Momentum, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.Momentum.Momentum(string,string,Jcd.Units.UnitTypes.Momentum,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.