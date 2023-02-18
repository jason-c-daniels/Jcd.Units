#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance')

## Resistance(string, string, Resistance, double, double) Constructor

Constructs a unit measuring a specified [Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance') using another Resistance as a reference.

```csharp
public Resistance(string name, string symbol, Jcd.Units.UnitTypes.Resistance baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Resistance.Resistance(string,string,Jcd.Units.UnitTypes.Resistance,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Resistance.Resistance(string,string,Jcd.Units.UnitTypes.Resistance,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance')

<a name='Jcd.Units.UnitTypes.Resistance.Resistance(string,string,Jcd.Units.UnitTypes.Resistance,double,double).baseUnit'></a>

`baseUnit` [Resistance](Jcd.Units.UnitTypes.Resistance.md 'Jcd.Units.UnitTypes.Resistance')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Resistance.Resistance(string,string,Jcd.Units.UnitTypes.Resistance,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Resistance.Resistance(string,string,Jcd.Units.UnitTypes.Resistance,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the `baseUnit`.