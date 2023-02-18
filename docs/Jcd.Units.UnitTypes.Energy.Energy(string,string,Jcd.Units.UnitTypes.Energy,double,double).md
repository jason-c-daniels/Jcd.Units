#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy')

## Energy(string, string, Energy, double, double) Constructor

Constructs a unit measuring a specified [Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy') using another [Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy') as a reference.

```csharp
public Energy(string name, string symbol, Jcd.Units.UnitTypes.Energy baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy')

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).baseUnit'></a>

`baseUnit` [Energy](Jcd.Units.UnitTypes.Energy.md 'Jcd.Units.UnitTypes.Energy')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).md#Jcd.Units.UnitTypes.Energy.Energy(string,string,Jcd.Units.UnitTypes.Energy,double,double).baseUnit 'Jcd.Units.UnitTypes.Energy.Energy(string, string, Jcd.Units.UnitTypes.Energy, double, double).baseUnit').