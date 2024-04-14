#### [Jcd.Units](index 'index')
### [Jcd.Units](Jcd.Units 'Jcd.Units').[UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

## UnitOfMeasure(string, string, double, double, string) Constructor

Base type to simplify creating a unit of measure. This type provides relational and equivalence operations.

```csharp
protected UnitOfMeasure(string Name, string Symbol, double Coefficient=1.0, double Offset=0.0, string System="");
```
#### Parameters

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,string).Name'></a>

`Name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of this unit

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,string).Symbol'></a>

`Symbol` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The symbol or abbreviation to represent the [UnitOfMeasure&lt;TUnit&gt;](UnitOfMeasure_TUnit_ 'Jcd.Units.UnitOfMeasure<TUnit>')

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,string).Coefficient'></a>

`Coefficient` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The unit's coefficient relative to the ultimate base unit's representation.

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,string).Offset'></a>

`Offset` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The offset used when computing values going to and from the base unit's representation.

<a name='Jcd.Units.UnitOfMeasure_TUnit_.UnitOfMeasure(string,string,double,double,string).System'></a>

`System` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The optional system name the unit of measure belongs to.