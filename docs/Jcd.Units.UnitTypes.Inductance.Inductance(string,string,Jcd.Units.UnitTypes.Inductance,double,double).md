#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Inductance](Jcd.Units.UnitTypes.Inductance.md 'Jcd.Units.UnitTypes.Inductance')

## Inductance(string, string, Inductance, double, double) Constructor

Constructs a unit measuring a specified `Inductance` using another Inductance as a reference.

```csharp
public Inductance(string name, string symbol, Jcd.Units.UnitTypes.Inductance baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Inductance.Inductance(string,string,Jcd.Units.UnitTypes.Inductance,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Inductance.Inductance(string,string,Jcd.Units.UnitTypes.Inductance,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the `Inductance`

<a name='Jcd.Units.UnitTypes.Inductance.Inductance(string,string,Jcd.Units.UnitTypes.Inductance,double,double).baseUnit'></a>

`baseUnit` [Inductance](Jcd.Units.UnitTypes.Inductance.md 'Jcd.Units.UnitTypes.Inductance')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Inductance.Inductance(string,string,Jcd.Units.UnitTypes.Inductance,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Inductance.Inductance(string,string,Jcd.Units.UnitTypes.Inductance,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the `baseUnit`.