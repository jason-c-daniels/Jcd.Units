#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Power Struct

Constructs a unit measuring a specified `Power`

```csharp
public struct Power :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Power>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')[Power](Jcd.Units.UnitTypes.Power.md 'Jcd.Units.UnitTypes.Power')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Jcd.Units.IUnitOfMeasure-1 'Jcd.Units.IUnitOfMeasure`1')

| Constructors | |
| :--- | :--- |
| [Power(string, string, double, double)](Jcd.Units.UnitTypes.Power.Power(string,string,double,double).md 'Jcd.Units.UnitTypes.Power.Power(string, string, double, double)') | Constructs a unit measuring a specified `Power` |
| [Power(string, string, Power, double, double)](Jcd.Units.UnitTypes.Power.Power(string,string,Jcd.Units.UnitTypes.Power,double,double).md 'Jcd.Units.UnitTypes.Power.Power(string, string, Jcd.Units.UnitTypes.Power, double, double)') | Constructs a unit measuring a specified `Power` using another Power as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Power.Coefficient.md 'Jcd.Units.UnitTypes.Power.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Power.Name.md 'Jcd.Units.UnitTypes.Power.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Power.Offset.md 'Jcd.Units.UnitTypes.Power.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Power.Symbol.md 'Jcd.Units.UnitTypes.Power.Symbol') | The symbol or abbreviation to represent the `Power` |

| Methods | |
| :--- | :--- |
| [CompareTo(Power)](Jcd.Units.UnitTypes.Power.CompareTo(Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.CompareTo(Jcd.Units.UnitTypes.Power)') | Performs a relative comparison between this `Power` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Power.CompareTo(object).md 'Jcd.Units.UnitTypes.Power.CompareTo(object)') | Performs a relative comparison between this `Power` and another one. |
| [Equals(Power)](Jcd.Units.UnitTypes.Power.Equals(Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.Equals(Jcd.Units.UnitTypes.Power)') | Compares this `Power` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Power.GetHashCode().md 'Jcd.Units.UnitTypes.Power.GetHashCode()') | Computes the hash code for this `Power` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Power, Power)](Jcd.Units.UnitTypes.Power.op_GreaterThan(Jcd.Units.UnitTypes.Power,Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.op_GreaterThan(Jcd.Units.UnitTypes.Power, Jcd.Units.UnitTypes.Power)') | Compares two `Power` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Power, Power)](Jcd.Units.UnitTypes.Power.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Power,Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Power, Jcd.Units.UnitTypes.Power)') | Compares two `Power` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Power, Power)](Jcd.Units.UnitTypes.Power.op_LessThan(Jcd.Units.UnitTypes.Power,Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.op_LessThan(Jcd.Units.UnitTypes.Power, Jcd.Units.UnitTypes.Power)') | Compares two `Power` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Power, Power)](Jcd.Units.UnitTypes.Power.op_LessThanOrEqual(Jcd.Units.UnitTypes.Power,Jcd.Units.UnitTypes.Power).md 'Jcd.Units.UnitTypes.Power.op_LessThanOrEqual(Jcd.Units.UnitTypes.Power, Jcd.Units.UnitTypes.Power)') | Compares two `Power` instances to determine if the left one is less than or equal to the right one. |
