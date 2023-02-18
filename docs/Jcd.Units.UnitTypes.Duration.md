#### [Jcd.Units](index.md 'index')
### [Jcd.Units.UnitTypes](Jcd.Units.UnitTypes.md 'Jcd.Units.UnitTypes')

## Duration Struct

Constructs a unit measuring a specified [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')

```csharp
public readonly struct Duration :
Jcd.Units.IUnitOfMeasure<Jcd.Units.UnitTypes.Duration>
```

Implements [Jcd.Units.IUnitOfMeasure&lt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')[Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration')[&gt;](Jcd.Units.IUnitOfMeasure_TUnits_.md 'Jcd.Units.IUnitOfMeasure<TUnits>')

| Constructors | |
| :--- | :--- |
| [Duration(string, string, double, double)](Jcd.Units.UnitTypes.Duration.Duration(string,string,double,double).md 'Jcd.Units.UnitTypes.Duration.Duration(string, string, double, double)') | Constructs a unit measuring a specified [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') |
| [Duration(string, string, Duration, double, double)](Jcd.Units.UnitTypes.Duration.Duration(string,string,Jcd.Units.UnitTypes.Duration,double,double).md 'Jcd.Units.UnitTypes.Duration.Duration(string, string, Jcd.Units.UnitTypes.Duration, double, double)') | Constructs a unit measuring a specified [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') using another Duration as a reference. |

| Properties | |
| :--- | :--- |
| [Coefficient](Jcd.Units.UnitTypes.Duration.Coefficient.md 'Jcd.Units.UnitTypes.Duration.Coefficient') | The unit's coefficient relative to the ultimate base unit's representation. |
| [Name](Jcd.Units.UnitTypes.Duration.Name.md 'Jcd.Units.UnitTypes.Duration.Name') | The name of this unit |
| [Offset](Jcd.Units.UnitTypes.Duration.Offset.md 'Jcd.Units.UnitTypes.Duration.Offset') | The offset used when computing values going to and from the base unit's representation. |
| [Symbol](Jcd.Units.UnitTypes.Duration.Symbol.md 'Jcd.Units.UnitTypes.Duration.Symbol') | The symbol or abbreviation to represent the [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') |

| Methods | |
| :--- | :--- |
| [CompareTo(Duration)](Jcd.Units.UnitTypes.Duration.CompareTo(Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.CompareTo(Jcd.Units.UnitTypes.Duration)') | Performs a relative comparison between this [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') and another one. |
| [CompareTo(object)](Jcd.Units.UnitTypes.Duration.CompareTo(object).md 'Jcd.Units.UnitTypes.Duration.CompareTo(object)') | Performs a relative comparison between this [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') and another one. |
| [Equals(Duration)](Jcd.Units.UnitTypes.Duration.Equals(Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.Equals(Jcd.Units.UnitTypes.Duration)') | Compares this [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') to another one for equality. |
| [GetHashCode()](Jcd.Units.UnitTypes.Duration.GetHashCode().md 'Jcd.Units.UnitTypes.Duration.GetHashCode()') | Computes the hash code for this [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') |

| Operators | |
| :--- | :--- |
| [operator &gt;(Duration, Duration)](Jcd.Units.UnitTypes.Duration.op_GreaterThan(Jcd.Units.UnitTypes.Duration,Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.op_GreaterThan(Jcd.Units.UnitTypes.Duration, Jcd.Units.UnitTypes.Duration)') | Compares two [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') instances to determine if the left one is greater than the right one. |
| [operator &gt;=(Duration, Duration)](Jcd.Units.UnitTypes.Duration.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Duration,Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.op_GreaterThanOrEqual(Jcd.Units.UnitTypes.Duration, Jcd.Units.UnitTypes.Duration)') | Compares two [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') instances to determine if the left one is greater than or equal to the right one. |
| [operator &lt;(Duration, Duration)](Jcd.Units.UnitTypes.Duration.op_LessThan(Jcd.Units.UnitTypes.Duration,Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.op_LessThan(Jcd.Units.UnitTypes.Duration, Jcd.Units.UnitTypes.Duration)') | Compares two [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') instances to determine if the left one is less than the right one. |
| [operator &lt;=(Duration, Duration)](Jcd.Units.UnitTypes.Duration.op_LessThanOrEqual(Jcd.Units.UnitTypes.Duration,Jcd.Units.UnitTypes.Duration).md 'Jcd.Units.UnitTypes.Duration.op_LessThanOrEqual(Jcd.Units.UnitTypes.Duration, Jcd.Units.UnitTypes.Duration)') | Compares two [Duration](Jcd.Units.UnitTypes.Duration.md 'Jcd.Units.UnitTypes.Duration') instances to determine if the left one is less than or equal to the right one. |
