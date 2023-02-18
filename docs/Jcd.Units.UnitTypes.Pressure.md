#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Pressure Struct

Constructs a unit measuring a specified `Pressure`

```csharp
public struct Pressure :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Pressure>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Pressure](Jcd.Units.UnitTypes.Pressure.md 'Jcd.Units.UnitTypes.Pressure')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Pressure(string, string, double, double)](Jcd.Units.UnitTypes.Pressure.Pressure(string,string,double,double).md 'Jcd.Units.UnitTypes.Pressure.Pressure(string, string, double, double)') | Constructs a unit measuring a specified `Pressure` |
| [Pressure(string, string, Pressure, double, double)](Jcd.Units.UnitTypes.Pressure.Pressure(string,string,Jcd.Units.UnitTypes.Pressure,double,double).md 'Jcd.Units.UnitTypes.Pressure.Pressure(string, string, Jcd.Units.UnitTypes.Pressure, double, double)') | Constructs a unit measuring a specified `Pressure` using another Pressure as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Pressure.Coefficient.md 'Jcd.Units.UnitTypes.Pressure.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Pressure.Name.md 'Jcd.Units.UnitTypes.Pressure.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Pressure.Offset.md 'Jcd.Units.UnitTypes.Pressure.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Pressure.Symbol.md 'Jcd.Units.UnitTypes.Pressure.Symbol') | The symbol or abbreviation to represent the `Pressure` |

| Methods | |
| :--- | :--- |
| [CompareTo(Pressure)](Jcd.Units.UnitTypes.Pressure.CompareTo(Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.CompareTo(Jcd.Units.UnitTypes.Pressure)') | Performs a relative comparison between this `Pressure` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Pressure.CompareTo(object).md 'Jcd.Units.UnitTypes.Pressure.CompareTo(object)') | Performs a relative comparison between this `Pressure` and another one. |
| [Equals(Pressure)](Jcd.Units.UnitTypes.Pressure.Equals(Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.Equals(Jcd.Units.UnitTypes.Pressure)') | Compares this `Pressure` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Pressure.GetHashCode().md 'Jcd.Units.UnitTypes.Pressure.GetHashCode()') | Computes the hash code for this `Pressure` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Pressure, Pressure)](Jcd.Units.UnitTypes.Pressure.op_GreaterThan(Jcd.Units.UnitTypes.Pressure,Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.op_GreaterThan(Jcd.Units.UnitTypes.Pressure, Jcd.Units.UnitTypes.Pressure)') | Compares two `Pressure` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Pressure, Pressure)](Jcd.Units.UnitTypes.Pressure.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Pressure,Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Pressure, Jcd.Units.UnitTypes.Pressure)') | Compares two `Pressure` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Pressure, Pressure)](Jcd.Units.UnitTypes.Pressure.op_LessThan(Jcd.Units.UnitTypes.Pressure,Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.op_LessThan(Jcd.Units.UnitTypes.Pressure, Jcd.Units.UnitTypes.Pressure)') | Compares two `Pressure` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Pressure, Pressure)](Jcd.Units.UnitTypes.Pressure.op_LessThanOrEqual(Jcd.Units.UnitTypes.Pressure,Jcd.Units.UnitTypes.Pressure).md 'Jcd.Units.UnitTypes.Pressure.op_LessThanOrEqual(Jcd.Units.UnitTypes.Pressure, Jcd.Units.UnitTypes.Pressure)') | Compares two `Pressure` instances to determine if the left one is less than or equal to the right one. |
