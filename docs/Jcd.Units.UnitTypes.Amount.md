#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Amount Struct

Constructs a unit measuring a specified `Amount`

```csharp
public struct Amount :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Amount>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')[Amount](Jcd.Units.UnitTypes.Amount.md 'Jcd.Units.UnitTypes.Amount')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')

| Constructors | |
| :--- | :--- |
| [Amount(string, string, double, double)](Jcd.Units.UnitTypes.Amount.Amount(string,string,double,double).md 'Jcd.Units.UnitTypes.Amount.Amount(string, string, double, double)') | Constructs a unit measuring a specified `Amount` |
| [Amount(string, string, Amount, double, double)](Jcd.Units.UnitTypes.Amount.Amount(string,string,Jcd.Units.UnitTypes.Amount,double,double).md 'Jcd.Units.UnitTypes.Amount.Amount(string, string, Jcd.Units.UnitTypes.Amount, double, double)') | Constructs a unit measuring a specified `Amount` using another Amount as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Amount.Coefficient.md 'Jcd.Units.UnitTypes.Amount.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Amount.Name.md 'Jcd.Units.UnitTypes.Amount.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Amount.Offset.md 'Jcd.Units.UnitTypes.Amount.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Amount.Symbol.md 'Jcd.Units.UnitTypes.Amount.Symbol') | The symbol or abbreviation to represent the `Amount` |

| Methods | |
| :--- | :--- |
| [CompareTo(Amount)](Jcd.Units.UnitTypes.Amount.CompareTo(Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.CompareTo(Jcd.Units.UnitTypes.Amount)') | Performs a relative comparison between this `Amount` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Amount.CompareTo(object).md 'Jcd.Units.UnitTypes.Amount.CompareTo(object)') | Performs a relative comparison between this `Amount` and another one. |
| [Equals(Amount)](Jcd.Units.UnitTypes.Amount.Equals(Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.Equals(Jcd.Units.UnitTypes.Amount)') | Compares this `Amount` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Amount.GetHashCode().md 'Jcd.Units.UnitTypes.Amount.GetHashCode()') | Computes the hash code for this `Amount` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Amount, Amount)](Jcd.Units.UnitTypes.Amount.op_GreaterThan(Jcd.Units.UnitTypes.Amount,Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.op_GreaterThan(Jcd.Units.UnitTypes.Amount, Jcd.Units.UnitTypes.Amount)') | Compares two `Amount` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Amount, Amount)](Jcd.Units.UnitTypes.Amount.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Amount,Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Amount, Jcd.Units.UnitTypes.Amount)') | Compares two `Amount` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Amount, Amount)](Jcd.Units.UnitTypes.Amount.op_LessThan(Jcd.Units.UnitTypes.Amount,Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.op_LessThan(Jcd.Units.UnitTypes.Amount, Jcd.Units.UnitTypes.Amount)') | Compares two `Amount` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Amount, Amount)](Jcd.Units.UnitTypes.Amount.op_LessThanOrEqual(Jcd.Units.UnitTypes.Amount,Jcd.Units.UnitTypes.Amount).md 'Jcd.Units.UnitTypes.Amount.op_LessThanOrEqual(Jcd.Units.UnitTypes.Amount, Jcd.Units.UnitTypes.Amount)') | Compares two `Amount` instances to determine if the left one is less than or equal to the right one. |
