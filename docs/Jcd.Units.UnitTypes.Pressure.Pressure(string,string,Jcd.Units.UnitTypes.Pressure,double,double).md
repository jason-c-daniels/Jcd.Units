#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')

## Pressure(string, string, Pressure, double, double) Constructor

Constructs a unit measuring a specified [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure') using another [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure') as a reference.

```csharp
public Pressure(string name, string symbol, Jcd.Units.UnitTypes.Pressure baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')

<a name='Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).baseUnit'></a>

`baseUnit` [Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).md#Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).baseUnit 'Jcd.Units.UnitTypes.Pressure.Pressure(string, string, Jcd.Units.UnitTypes.Pressure, double, double).baseUnit').