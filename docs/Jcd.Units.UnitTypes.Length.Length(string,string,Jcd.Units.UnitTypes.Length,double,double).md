#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length')

## Length(string, string, Length, double, double) Constructor

Constructs a unit measuring a specified [Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length') using another Length as a reference.

```csharp
public Length(string name, string symbol, Jcd.Units.UnitTypes.Length baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length')

<a name='Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).baseUnit'></a>

`baseUnit` [Length](Jcd.Units.UnitTypes.Length.md 'Jcd.Units.UnitTypes.Length')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).md#Jcd.Units.UnitTypes.Length.Length(string,string,Jcd.Units.UnitTypes.Length,double,double).baseUnit 'Jcd.Units.UnitTypes.Length.Length(string, string, Jcd.Units.UnitTypes.Length, double, double).baseUnit').