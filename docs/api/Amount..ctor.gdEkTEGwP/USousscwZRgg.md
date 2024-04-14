#### [Jcd.Units](index 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes 'Jcd.Units.UnitTypes').[Amount](Amount 'Jcd.Units.UnitTypes.Amount')

## Amount(string, string, Amount, double, double, IValueComparer<double>, string) Constructor

Constructs a unit measuring a specified [Amount](Amount 'Jcd.Units.UnitTypes.Amount') using another [Amount](Amount 'Jcd.Units.UnitTypes.Amount') as a reference.

```csharp
public Amount(string name, string symbol, Jcd.Units.UnitTypes.Amount? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Amount](Amount 'Jcd.Units.UnitTypes.Amount')

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [Amount](Amount 'Jcd.Units.UnitTypes.Amount')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Amount..ctor.gdEkTEGwP/USousscwZRgg#Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Amount.Amount(string, string, Jcd.Units.UnitTypes.Amount, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Amount..ctor.gdEkTEGwP/USousscwZRgg#Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Amount.Amount(string, string, Jcd.Units.UnitTypes.Amount, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_ 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system the unit of measure belongs to.