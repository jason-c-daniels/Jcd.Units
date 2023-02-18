#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force')

## Force(string, string, Force, double, double) Constructor

Constructs a unit measuring a specified [Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force') using another [Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force') as a reference.

```csharp
public Force(string name, string symbol, Jcd.Units.UnitTypes.Force baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force')

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).baseUnit'></a>

`baseUnit` [Force](Jcd.Units.UnitTypes.Force.md 'Jcd.Units.UnitTypes.Force')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).md#Jcd.Units.UnitTypes.Force.Force(string,string,Jcd.Units.UnitTypes.Force,double,double).baseUnit 'Jcd.Units.UnitTypes.Force.Force(string, string, Jcd.Units.UnitTypes.Force, double, double).baseUnit').