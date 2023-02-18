#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Frequency Struct

Constructs a unit measuring a specified `Frequency`

```csharp
public struct Frequency :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Frequency>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Frequency](Jcd.Units.UnitTypes.Frequency.md 'Jcd.Units.UnitTypes.Frequency')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Frequency(string, string, double, double)](Jcd.Units.UnitTypes.Frequency.Frequency(string,string,double,double).md 'Jcd.Units.UnitTypes.Frequency.Frequency(string, string, double, double)') | Constructs a unit measuring a specified `Frequency` |
| [Frequency(string, string, Frequency, double, double)](Jcd.Units.UnitTypes.Frequency.Frequency(string,string,Jcd.Units.UnitTypes.Frequency,double,double).md 'Jcd.Units.UnitTypes.Frequency.Frequency(string, string, Jcd.Units.UnitTypes.Frequency, double, double)') | Constructs a unit measuring a specified `Frequency` using another Frequency as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Frequency.Coefficient.md 'Jcd.Units.UnitTypes.Frequency.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Frequency.Name.md 'Jcd.Units.UnitTypes.Frequency.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Frequency.Offset.md 'Jcd.Units.UnitTypes.Frequency.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Frequency.Symbol.md 'Jcd.Units.UnitTypes.Frequency.Symbol') | The symbol or abbreviation to represent the `Frequency` |

| Methods | |
| :--- | :--- |
| [CompareTo(Frequency)](Jcd.Units.UnitTypes.Frequency.CompareTo(Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.CompareTo(Jcd.Units.UnitTypes.Frequency)') | Performs a relative comparison between this `Frequency` and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Frequency.CompareTo(object).md 'Jcd.Units.UnitTypes.Frequency.CompareTo(object)') | Performs a relative comparison between this `Frequency` and another one. |
| [Equals(Frequency)](Jcd.Units.UnitTypes.Frequency.Equals(Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.Equals(Jcd.Units.UnitTypes.Frequency)') | Compares this `Frequency` to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Frequency.GetHashCode().md 'Jcd.Units.UnitTypes.Frequency.GetHashCode()') | Computes the hash code for this `Frequency` |

| Operators | |
| :--- | :--- |
| [operator &gt;(Frequency, Frequency)](Jcd.Units.UnitTypes.Frequency.op_GreaterThan(Jcd.Units.UnitTypes.Frequency,Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.op_GreaterThan(Jcd.Units.UnitTypes.Frequency, Jcd.Units.UnitTypes.Frequency)') | Compares two `Frequency` instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Frequency, Frequency)](Jcd.Units.UnitTypes.Frequency.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Frequency,Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Frequency, Jcd.Units.UnitTypes.Frequency)') | Compares two `Frequency` instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Frequency, Frequency)](Jcd.Units.UnitTypes.Frequency.op_LessThan(Jcd.Units.UnitTypes.Frequency,Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.op_LessThan(Jcd.Units.UnitTypes.Frequency, Jcd.Units.UnitTypes.Frequency)') | Compares two `Frequency` instances to determine if the left one is less than the right one. |
| [operator &lt;=(Frequency, Frequency)](Jcd.Units.UnitTypes.Frequency.op_LessThanOrEqual(Jcd.Units.UnitTypes.Frequency,Jcd.Units.UnitTypes.Frequency).md 'Jcd.Units.UnitTypes.Frequency.op_LessThanOrEqual(Jcd.Units.UnitTypes.Frequency, Jcd.Units.UnitTypes.Frequency)') | Compares two `Frequency` instances to determine if the left one is less than or equal to the right one. |
