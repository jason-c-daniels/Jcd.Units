#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Force](Force.md 'Jcd.Units.UnitTypes.Force')

## Force(string, string, Force, double, double, IValueComparer<double>, string) Constructor

Constructs a unit measuring a specified [Force](Force.md 'Jcd.Units.UnitTypes.Force') using another [Force](Force.md 'Jcd.Units.UnitTypes.Force') as a reference.

```csharp
public Force(string name, string symbol, Jcd.Units.UnitTypes.Force? baseUnit=null, double coefficient=1.0, double offset=0.0, Jcd.Units.IValueComparer<double>? comparer=null, string system="");
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Force](Force.md 'Jcd.Units.UnitTypes.Force')

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit'></a>

`baseUnit` [Force](Force.md 'Jcd.Units.UnitTypes.Force')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the [baseUnit](Force..ctor.CKhm1HvvMJNrJLur90LQPw.md#Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Force.Force(string, string, Jcd.Units.UnitTypes.Force, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit')

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Force..ctor.CKhm1HvvMJNrJLur90LQPw.md#Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).baseUnit 'Jcd.Units.UnitTypes.Force.Force(string, string, Jcd.Units.UnitTypes.Force, double, double, Jcd.Units.IValueComparer<double>, string).baseUnit').

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).comparer'></a>

`comparer` [Jcd.Units.IValueComparer&lt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>')

The instance specific [IValueComparer&lt;T&gt;](IValueComparer_T_.md 'Jcd.Units.IValueComparer<T>') used for comparisons.

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double,Jcd.Units.IValueComparer_double_,string).system'></a>

`system` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system the unit of measure belongs to.