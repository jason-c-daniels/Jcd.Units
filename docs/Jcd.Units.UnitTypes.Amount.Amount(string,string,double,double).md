#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

## Amount(string, string, double, double) Constructor

Constructs a unit measuring a specified [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

```csharp
public Amount(string Name, string Symbol, double Coefficient=1.0, double Offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,double,double).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,double,double).Symbol'></a>

`Symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,double,double).Coefficient'></a>

`Coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The unit's coefficient relative to the ultimate base unit's representation.

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,double,double).Offset'></a>

`Offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset used when computing values going to and from the base unit's representation.