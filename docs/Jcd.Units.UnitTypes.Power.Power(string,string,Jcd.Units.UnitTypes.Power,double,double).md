#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')

## Power(string, string, Power, double, double) Constructor

Constructs a unit measuring a specified [Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power') using another Power as a reference.

```csharp
public Power(string name, string symbol, Jcd.Units.UnitTypes.Power baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')

<a name='Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).baseUnit'></a>

`baseUnit` [Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the `baseUnit`.