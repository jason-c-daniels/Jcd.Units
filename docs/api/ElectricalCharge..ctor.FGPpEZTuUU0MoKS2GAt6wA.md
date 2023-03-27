#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge')

## ElectricalCharge(string, string, ElectricalCharge, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge') using another [ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge') as a reference.

```csharp
public ElectricalCharge(string name, string symbol, Jcd.Units.UnitTypes.ElectricalCharge? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge')

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [ElectricalCharge](ElectricalCharge.md 'Jcd.Units.UnitTypes.ElectricalCharge')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](ElectricalCharge..ctor.FGPpEZTuUU0MoKS2GAt6wA.md#Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string, string, Jcd.Units.UnitTypes.ElectricalCharge, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](ElectricalCharge..ctor.FGPpEZTuUU0MoKS2GAt6wA.md#Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string, string, Jcd.Units.UnitTypes.ElectricalCharge, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.ElectricalCharge.ElectricalCharge(string,string,Jcd.Units.UnitTypes.ElectricalCharge,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.