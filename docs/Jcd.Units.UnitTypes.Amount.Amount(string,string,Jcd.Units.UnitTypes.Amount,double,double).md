#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes').[Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

## Amount(string, string, Amount, double, double) Constructor

Constructs a unit measuring a specified [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount') using another Amount as a reference.

```csharp
public Amount(string name, string symbol, Jcd.Units.UnitTypes.Amount baseUnit, double coefficient, double offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).symbol'></a>

`symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).baseUnit'></a>

`baseUnit` [Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')

The unit to use as a base

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).coefficient'></a>

`coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The coefficient relative to the `baseUnit`

<a name='Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).offset'></a>

`offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset from the `baseUnit`.