#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Angle](Angle.md 'Jcd.Units.UnitTypes.Angle')

## Angle(string, string, Angle, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [Angle](Angle.md 'Jcd.Units.UnitTypes.Angle') using another [Angle](Angle.md 'Jcd.Units.UnitTypes.Angle') as a reference.

```csharp
public Angle(string name, string symbol, Jcd.Units.UnitTypes.Angle? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Angle](Angle.md 'Jcd.Units.UnitTypes.Angle')

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [Angle](Angle.md 'Jcd.Units.UnitTypes.Angle')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Angle..ctor.TQxdIsDwspUDppqDAiCZ5Q.md#Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Angle.Angle(string, string, Jcd.Units.UnitTypes.Angle, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Angle..ctor.TQxdIsDwspUDppqDAiCZ5Q.md#Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Angle.Angle(string, string, Jcd.Units.UnitTypes.Angle, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.Angle.Angle(string,string,Jcd.Units.UnitTypes.Angle,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.