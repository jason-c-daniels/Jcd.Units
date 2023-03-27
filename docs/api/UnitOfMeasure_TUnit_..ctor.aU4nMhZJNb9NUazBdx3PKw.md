#### [Jcd.Units](index.md 'index')
### [Jcd.Units](Jcd.Units.md 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure(string, string, double, double) Constructor

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
protected UnitOfMeasure(string Name, string Symbol, double Coefficient=1.0, double Offset=0.0);
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double).Symbol'></a>

`Symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_.md 'Jcd.Units.UnitOfMeasure<TUnit>')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double).Coefficient'></a>

`Coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The unit's coefficient relative to the ultimate base unit's representation.

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double).Offset'></a>

`Offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset used when computing values going to and from the base unit's representation.