#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass')

## Mass(string, string, Mass, double, double) Constructor

Constructs a unit measuring a specified [Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass') using another [Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass') as a reference.

```csharp
public Mass(string name, string symbol, Jcd.Units.UnitTypes.Mass baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass')

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).baseUnit'></a>

`baseUnit` [Mass](Jcd.Units.UnitTypes.Mass.md 'Jcd.Units.UnitTypes.Mass')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).md#Jcd.Units.UnitTypes.Mass.Mass(string,string,Jcd.Units.UnitTypes.Mass,double,double).baseUnit 'Jcd.Units.UnitTypes.Mass.Mass(string, string, Jcd.Units.UnitTypes.Mass, double, double).baseUnit').