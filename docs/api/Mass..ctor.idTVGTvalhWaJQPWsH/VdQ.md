#### [Jcd.Units](index 'index')

### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes 'Jcd.Units.UnitTypes').[Mass](Mass 'Jcd.Units.UnitTypes.Mass')

## Mass(string, string, Mass, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [Mass](Mass 'Jcd.Units.UnitTypes.Mass') using another [Mass](Mass 'Jcd.Units.UnitTypes.Mass') as a reference.

```csharp
public Mass(string name, string symbol, Jcd.Units.UnitTypes.Mass? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```

#### Parameters

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Mass](Mass 'Jcd.Units.UnitTypes.Mass')

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [Mass](Mass 'Jcd.Units.UnitTypes.Mass')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Mass..ctor.idTVGTvalhWaJQPWsH/VdQ#Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Mass.Mass(string, string, Jcd.Units.UnitTypes.Mass, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Mass..ctor.idTVGTvalhWaJQPWsH/VdQ#Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Mass.Mass(string, string, Jcd.Units.UnitTypes.Mass, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons.