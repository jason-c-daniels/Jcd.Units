#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')

## Duration(string, string, Duration, double, double) Constructor

Constructs a unit measuring a specified `Duration` using another Duration as a reference.

```csharp
public Duration(string name, string symbol, Jcd.Units.UnitTypes.Duration baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the `Duration`

<a name='Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).baseUnit'></a>

`baseUnit` [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the `baseUnit`.