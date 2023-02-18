#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

## Temperature(string, string, Temperature, double, double) Constructor

Constructs a unit measuring a specified [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature') using another Temperature as a reference.

```csharp
public Temperature(string name, string symbol, Jcd.Units.UnitTypes.Temperature baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

<a name='Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).baseUnit'></a>

`baseUnit` [Temperature](Jcd.Units.UnitTypes.Temperature.md 'Jcd.Units.UnitTypes.Temperature')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the [baseUnit](Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).md#Jcd.Units.UnitTypes.Temperature.Temperature(string,string,Jcd.Units.UnitTypes.Temperature,double,double).baseUnit 'Jcd.Units.UnitTypes.Temperature.Temperature(string, string, Jcd.Units.UnitTypes.Temperature, double, double).baseUnit').