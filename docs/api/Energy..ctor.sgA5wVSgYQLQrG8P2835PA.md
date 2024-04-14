#### [Jcd.Units](index.md 'index')

### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Energy](Energy.md 'Jcd.Units.UnitTypes.Energy')

## Energy(string, string, Energy, double, double, IValueComparer<double>, string) Constructor

Constructs a unit measuring a specified [Energy](Energy.md 'Jcd.Units.UnitTypes.Energy') using another [Energy](Energy.md 'Jcd.Units.UnitTypes.Energy') as a reference.

```csharp
public Energy(string name, string symbol, Jcd.Units.UnitTypes.Energy? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```

#### Parameters

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Energy](Energy.md 'Jcd.Units.UnitTypes.Energy')

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [Energy](Energy.md 'Jcd.Units.UnitTypes.Energy')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Energy..ctor.sgA5wVSgYQLQrG8P2835PA.md#Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Energy.Energy(string, string, Jcd.Units.UnitTypes.Energy, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Energy..ctor.sgA5wVSgYQLQrG8P2835PA.md#Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Energy.Energy(string, string, Jcd.Units.UnitTypes.Energy, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system the unit of measure belongs to.