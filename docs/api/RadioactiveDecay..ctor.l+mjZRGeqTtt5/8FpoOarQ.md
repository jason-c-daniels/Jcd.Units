#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')

## RadioactiveDecay(string, string, RadioactiveDecay, double, double, IValueComparer<double>) Constructor

Constructs a unit measuring a specified [RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay') using another [RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay') as a reference.

```csharp
public RadioactiveDecay(string name, string symbol, Jcd.Units.UnitTypes.RadioactiveDecay? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).baseUnit'></a>

`baseUnit` [RadioactiveDecay](RadioactiveDecay.md 'Jcd.Units.UnitTypes.RadioactiveDecay')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](RadioactiveDecay..ctor.l+mjZRGeqTtt5/8FpoOarQ.md#Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string, string, Jcd.Units.UnitTypes.RadioactiveDecay, double, double, Jcd.Units.IValueComparer<double>).baseUnit')

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](RadioactiveDecay..ctor.l+mjZRGeqTtt5/8FpoOarQ.md#Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).baseUnit 'Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string, string, Jcd.Units.UnitTypes.RadioactiveDecay, double, double, Jcd.Units.IValueComparer<double>).baseUnit').

<a name='Jcd.Units.UnitTypes.RadioactiveDecay.RadioactiveDecay(string,string,Jcd.Units.UnitTypes.RadioactiveDecay,double,double,Jcd.Units.IValueComparer_double_).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.