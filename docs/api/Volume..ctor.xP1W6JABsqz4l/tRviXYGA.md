#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Volume](Volume.md 'Jcd.Units.UnitTypes.Volume')

## Volume(string, string, Volume, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [Volume](Volume.md 'Jcd.Units.UnitTypes.Volume') using another [Volume](Volume.md 'Jcd.Units.UnitTypes.Volume') as a reference.

```csharp
public Volume(string name, string symbol, Jcd.Units.UnitTypes.Volume? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Volume](Volume.md 'Jcd.Units.UnitTypes.Volume')

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [Volume](Volume.md 'Jcd.Units.UnitTypes.Volume')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Volume..ctor.xP1W6JABsqz4l/tRviXYGA.md#Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Volume.Volume(string, string, Jcd.Units.UnitTypes.Volume, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Volume..ctor.xP1W6JABsqz4l/tRviXYGA.md#Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.Volume.Volume(string, string, Jcd.Units.UnitTypes.Volume, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.Volume.Volume(string,string,Jcd.Units.UnitTypes.Volume,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.